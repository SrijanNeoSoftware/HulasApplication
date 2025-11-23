using HulasApplication.Model;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;
using HulasApplication.Model.MotorApi;

namespace HulasApplication.Common
{
	

	public class httpapi
	{
		private static IConfiguration config;


		public static void Init(IConfiguration _config)
		{
			config = _config;
		}
		public static async Task<T> Get<T>(string url, Insurers data)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(data.url);
				var token = await GetToken(data);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

				var content = new StringContent("{}", Encoding.UTF8, "application/json");

				var result = await client.PostAsync(url, content);
				result.EnsureSuccessStatusCode();

				string resultContentString = await result.Content.ReadAsStringAsync();
				T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
				return resultContent;
			}
		}
		public static async Task<string> GetToken(Insurers data)
		{
			using (HttpClient client = new HttpClient())
			{
				string apiUrl = $"{data.url}API/Auth/token";
				var requestParameters = new
				{
					UserName = $"{data.UserName}",
					Password = $"{data.Password}"
				};
				var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(requestParameters);
				var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
				HttpResponseMessage response = await client.PostAsync(apiUrl, content);
				if (response.IsSuccessStatusCode)
				{
					string responseContent = await response.Content.ReadAsStringAsync();
					dynamic jsonObject = JsonConvert.DeserializeObject(responseContent);
					string token = jsonObject.tokenString;
					return token;
				}
				else
				{
					Console.WriteLine("Error: " + response.StatusCode);
					return null;
				}

			}
		}
		public static async Task<T> GetDistrict<T>(string url, int provinceCode, Insurers data)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(data.url);
				var token = await GetToken(data);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
				var requestParam = new
				{
					provinceCode = provinceCode
				};
				var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(requestParam);
				var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
				var result = await client.PostAsync(url, content);
				result.EnsureSuccessStatusCode();
				string resultContentString = await result.Content.ReadAsStringAsync();
				T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
				return resultContent;
			}
		}

		public static async Task<T> GetCategoty<T>(string url, int ClassId, Insurers data)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(data.url);
				var token = await GetToken(data);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
				var requestParam = new
				{
					ClassId = ClassId
				};
				var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(requestParam);
				var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
				var result = await client.PostAsync(url, content);
				result.EnsureSuccessStatusCode();
				string resultContentString = await result.Content.ReadAsStringAsync();
				T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
				return resultContent;
			}
		}
		public static async Task<T> GetMNU<T>(string url, int districtId, Insurers data)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(data.url);
				var token = await GetToken(data);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
				var requestParam = new
				{
					DistrictId = districtId
				};
				var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(requestParam);
				var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
				var result = await client.PostAsync(url, content);
				result.EnsureSuccessStatusCode();
				string resultContentString = await result.Content.ReadAsStringAsync();
				T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
				return resultContent;
			}
		}

		public static async Task<T> GetKycOccupation<T>(string url, int kycRiskCategoryId, Insurers data)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(data.url);
				var token = await GetToken(data);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
				var requestParam = new
				{
					kycRiskCategory = kycRiskCategoryId
				};
				var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(requestParam);
				var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
				var result = await client.PostAsync(url, content);
				result.EnsureSuccessStatusCode();
				string resultContentString = await result.Content.ReadAsStringAsync();
				T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
				return resultContent;
			}
		}
		public static async Task<GetQuoteApiResponse> PostMotorPremium(string url, Insurers data, VehicleInfo model)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(data.url);
				var token = await GetToken(data);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
				var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(model);
				var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
				var result = await client.PostAsync(url, content);
				result.EnsureSuccessStatusCode();
				string resultContentString = await result.Content.ReadAsStringAsync();
				GetQuoteApiResponse resultContent = JsonConvert.DeserializeObject<GetQuoteApiResponse>(resultContentString);
				return resultContent;
			}
		}
		public static async Task<T> GetVehilceName<T>(string url, int CategoryId, Insurers data)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(data.url);
				var token = await GetToken(data);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
				var requestParam = new
				{
					CategoryId = CategoryId
				};
				var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(requestParam);
				var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
				var result = await client.PostAsync(url, content);
				result.EnsureSuccessStatusCode();
				string resultContentString = await result.Content.ReadAsStringAsync();
				T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
				return resultContent;
			}
		}
		public static async Task<T> getVehicleModel<T>(string url, int makevehiclecompanyid, Insurers data)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(data.url);
				var token = await GetToken(data);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
				var requestParam = new
				{
					makevehiclecompanyid = makevehiclecompanyid
				};
				var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(requestParam);
				var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
				var result = await client.PostAsync(url, content);
				result.EnsureSuccessStatusCode();
				string resultContentString = await result.Content.ReadAsStringAsync();
				T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
				return resultContent;
			}
		}

	}
}
