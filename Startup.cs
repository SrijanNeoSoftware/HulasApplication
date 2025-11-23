using HulasApplication.Common;
using HulasApplication.Services.Common;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Events;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HulasApplication
{
	public class Startup
	{
		private readonly string LogFolderAddress;

		public Startup(IConfiguration configuration, IWebHostEnvironment env)
		{
			Configuration = configuration;
			LogFolderAddress = env.IsDevelopment() ? $@"C:\LogFolderUAT" : configuration.GetSection("LoggerUAT")["LogFolder"];
		}

		public IConfiguration Configuration { get; }


		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			var Logger = new LoggerConfiguration()
		   .MinimumLevel.Information()
		   .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
		   .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
		   .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
		   .MinimumLevel.Override("Microsoft.AspNetCore.Identity.RoleManager", LogEventLevel.Error)
		   .MinimumLevel.Override("Microsoft.AspNetCore.HttpsPolicy.HttpsRedirectionMiddleware", LogEventLevel.Warning)
		   .MinimumLevel.Override("Microsoft.EntityFrameworkCore.Model.Validation", LogEventLevel.Warning)
		   .WriteTo.File(path: $@"{LogFolderAddress}/{DateTime.Now.ToString("yyyy-MM-dd")}\log.txt",
		   outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {SourceContext}: {Message:lj}{NewLine}{Exception}",
		   rollingInterval: RollingInterval.Day)
		   .CreateLogger();
			httpapi.Init(Configuration);
			services.AddTransient<ICommonService, CommonService>();
			services.AddLogging(loggingBuilder =>
							   loggingBuilder.AddSerilog(Logger, dispose: true));
			services.AddControllers().AddJsonOptions(options =>
			{
				options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
				options.JsonSerializerOptions.PropertyNamingPolicy = null;
				options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
			});
			services.AddRazorPages();
			services.AddSession(so =>
			{
				so.IdleTimeout = TimeSpan.FromSeconds(120);
			});
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1",
					new OpenApiInfo
					{
						Title = "API",
						Version = "v1",
						Description = "API endpoint "
					}
				 );

				c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				{
					Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
					In = ParameterLocation.Header,
					Name = "Authorization",
					Type = SecuritySchemeType.ApiKey
				});
				c.OperationFilter<SecurityRequirementsOperationFilter>();
				c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

			});
			var jwtIssuer = Configuration.GetSection("Jwt:Issuer").Get<string>();
			var jwtKey = Configuration.GetSection("Jwt:Key").Get<string>();
			services.AddAuthentication(opt =>
			{
				opt.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
				//opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				//opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
	   .AddJwtBearer(options =>
	   {
		   options.TokenValidationParameters = new TokenValidationParameters
		   {
			   ValidateIssuer = true,
			   ValidateAudience = true,
			   ValidateLifetime = true,
			   ValidateIssuerSigningKey = true,
			   ValidIssuer = jwtIssuer,
			   ValidAudience = jwtIssuer,
			   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))
		   };
	   });
			services.AddControllersWithViews();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c =>
				{
					c.SwaggerEndpoint("/swagger/v1/swagger.json", "API");


				});
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();
			app.UseCors(x =>
			{
				x.AllowAnyOrigin();
				x.AllowAnyMethod();
				x.AllowAnyHeader();
			});
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
