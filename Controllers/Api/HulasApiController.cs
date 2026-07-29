using HulasApplication.Common;
using HulasApplication.Model.Mobile.ResponseModel;
using HulasApplication.Model.MotorApi;
using HulasApplication.Services.Common;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace HulasApplication.Controllers.Api
{
	public class HulasController : ControllerBase
	{
		private readonly ICommonService _commonService;
		private readonly ILogger<HulasController> _logger;
		private readonly string _ConnectionString;
		private static IConfiguration _config;


		public HulasController(ICommonService commonService, IConfiguration config,ILogger<HulasController> logger)
		{
			_commonService = commonService;
			_config = config;
			_ConnectionString = _config.GetConnectionString("NeoInsuranceWebContextConnection");
			_logger = logger;

		}

		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[Microsoft.AspNetCore.Mvc.HttpPost]
		[Route("getProvince")]
		public async Task<IActionResult> GetProvince()
		{
			try
			{
				var insurerId = 2;

				var data = await _commonService.GetInsurers(insurerId);
				var province = await httpapi.Get<GetProvince>("/API/Utility/GetProvince", data);
				return Ok(province);
			}
			catch (Exception ex)
			{
				return Ok(new { success = 0, message = ex.Message });
			}
		}
		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[Microsoft.AspNetCore.Mvc.HttpPost]
		[Route("getDistrict")]
		public async Task<IActionResult> GetDistrict([FromBody] getDistrict model)
		{
			try
			{
				var insurerId = 2;
				var data = await _commonService.GetInsurers(insurerId);
				var district = await httpapi.GetDistrict<GetDistrict>("/API/Utility/GetDistrict", model.provinceId, data);

				return Ok(district);
			}
			catch (Exception ex)
			{
				return Ok(new { success = 0, message = ex.Message });
			}
		}

		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[Microsoft.AspNetCore.Mvc.HttpPost]
		[Route("GetMNU")]
		public async Task<IActionResult> GetMNU([FromBody] getMnu model)
		{
			try
			{
				var insurerId = 2;
				var data = await _commonService.GetInsurers(insurerId);
				var mnu = await httpapi.GetMNU<GetMNU>("/API/Utility/GetMNU", model.districtId, data);

				return Ok(mnu);
			}
			catch (Exception ex)
			{
				return Ok(new { success = 0, message = ex.Message });
			}
		}

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("getMerchantBalance")]
        public async Task<IActionResult> GetMerchantBalance()
        {
            try
            {
                var insurerId = 2;
                var data = await _commonService.GetInsurers(insurerId);
                int merchantPaymentId = _config.GetValue<int>("NLGApiURL:MerchantId");

                var response = await httpapi.GetMerchantBalance("/api/Utility/GetMerchantAccountBalance", data, merchantPaymentId);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return Ok(new { success = 0, message = ex.Message });
            }
        }


        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[Microsoft.AspNetCore.Mvc.HttpPost]
		[Route("getQuote")]
		public async Task<IActionResult> GetQuote([FromBody] VehicleInfo model)
		{
			try
			{
				var insurerId = 2;
				var data = await _commonService.GetInsurers(insurerId);
				var district = await httpapi.PostMotorPremium("API/Motor/CalculateMotorPremium", data, model);

				return Ok(district);
			}
			catch (Exception ex)
			{
				return Ok(new { success = 0, message = ex.Message });
			}
		}

		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[Microsoft.AspNetCore.Mvc.HttpPost]
		[Route("getClass")]
		public async Task<IActionResult> GetClass()
		{
			try
			{
				var insurerId = 2;
				var data = await _commonService.GetInsurers(insurerId);
				var district = await httpapi.Get<GetClassApiResponse>("API/Motor/GetClass", data);

				return Ok(district);
			}
			catch (Exception ex)
			{
				return Ok(new { success = 0, message = ex.Message });
			}
		}
		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[Microsoft.AspNetCore.Mvc.HttpPost]
		[Route("getCategory")]
		public async Task<IActionResult> GetCategory([FromBody] getManufacture model)
		{
			try
			{
				var insurerId = 2;
				var data = await _commonService.GetInsurers(insurerId);
				var district = await httpapi.GetCategoty<GetCategoryApiResponse>("API/Motor/getCategorylist", model.classId, data);

				return Ok(district);
			}
			catch (Exception ex)
			{
				return Ok(new { success = 0, message = ex.Message });
			}
		}
		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[Microsoft.AspNetCore.Mvc.HttpPost]
		[Route("getManufacture")]
		public async Task<IActionResult> GetVehicleName([FromBody] getManufacture model)
		{
			try
			{
				var insurerId = 2;
				var data = await _commonService.GetInsurers(insurerId);
				var district = await httpapi.GetVehilceName<GetManufacturerApiResponse>("API/Motor/GetVehicleCompanyList", model.classId, data);

				return Ok(district);
			}
			catch (Exception ex)
			{
				return Ok(new { success = 0, message = ex.Message });
			}
		}
		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[Microsoft.AspNetCore.Mvc.HttpPost]
		[Route("getvehiclenamelist")]
		public async Task<IActionResult> GetVehicleNameList([FromBody] getvehiclenamelist model)
		{
			try
			{
				var insurerId = 2;
				var data = await _commonService.GetInsurers(insurerId);
				var district = await httpapi.GetVehilceName<GetManufacturerApiResponse>("API/Motor/getvehiclenamelist", model.CategoryId, data);

				return Ok(district);
			}
			catch (Exception ex)
			{
				return Ok(new { success = 0, message = ex.Message });
			}
		}

		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[Microsoft.AspNetCore.Mvc.HttpPost]
		[Route("getVehicleModel")]
		public async Task<IActionResult> getVehicleModel([FromBody] VehicleModelRequest model)
		{
			try
			{
				var insurerId = 2;
				var data = await _commonService.GetInsurers(insurerId);
				var district = await httpapi.getVehicleModel<GetManufacturerApiResponse>("API/Motor/GetVehicleModel", model.MakeVehicleCompanyId, data);

				return Ok(district);
			}
			catch (Exception ex)
			{
				return Ok(new { success = 0, message = ex.Message });
			}
		}

		[HttpPost]
		[Route("getToken")]
		public IActionResult Post([FromBody] GetAToken model)
		{
			var UserName = $"{_config["Hulas:UserName"]}";
			var Password = $"{_config["Hulas:Password"]}";


			if (model.UserName == UserName && model.Password == Password)
			{

				var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
				var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

				var Sectoken = new JwtSecurityToken(_config["Jwt:Issuer"],
				  _config["Jwt:Issuer"],
				  null,
				  expires: DateTime.Now.AddMinutes(30),
				  signingCredentials: credentials);

				var token = new JwtSecurityTokenHandler().WriteToken(Sectoken);

				return Ok(new { tokenString = token, ExpiryTime = "30 min" });
			}
			else
			{
				return BadRequest();
			}
		}
        /*[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[HttpPost]
		[Route("PostMotor")]
		public async Task<IActionResult> PostMotorProforma([FromBody] HulasPolicy model)
		{
			if (model == null)
				return Ok(new { responseCode = "1", responseMessage = "Invalid client request." });

			_logger.LogInformation($"Create Hulas Policy {model.KycDetails.Name}");

			try
			{
				var KycDetailsId = await _commonService.InsertKYCDetails(model.KycDetails);
				model.MotorDetails.KycId = KycDetailsId;
				model.PremiumDetails.KycId = KycDetailsId;
				model.CommonPolicyDetails.KycId = KycDetailsId;

				foreach (var photo in model.KycDetails.Photos)
				{
					photo.KycId = KycDetailsId;
				}

				foreach (var attachment in model.MotorDetails.ProductAttachments)
				{
					attachment.KycId = KycDetailsId;
				}

				var commonPolicy = await _commonService.InsertCommonPolicyDetails(model.CommonPolicyDetails);
				var photoInsertResult = await _commonService.InsertPhoto(model.KycDetails.Photos);
				var motorInsertResult = await _commonService.InsertMotorDetails(model.MotorDetails);
				var premiumInsertResult = await _commonService.InsertPremiumDetail(model.PremiumDetails);
				var productInsertResult = await _commonService.InsertProductAttachment(model.MotorDetails.ProductAttachments);

				var outputData = new ProformaOutput
				{
					Flag = "SUCCESS",
					SuccFailMsg = "Proforma Created Successfully",
					ProformaNo = "01/MT18/019754",
					Insured = $"{model.KycDetails.Name}",
					ClassName = "Motor Cycle",
					KycNo = "01001025306",
					KycId = KycDetailsId.ToString(),
					SumInsured = 0.00m,
					TpPremium = model.PremiumDetails.TotalPayablePremium,
					DocumentNo = "NULL",
					ReceiptNo = "NULL",
					ReceiptDate = "NULL",
					EffectiveDate = model.CommonPolicyDetails.EffectiveDt,
					ExpiryDate = model.CommonPolicyDetails.ExpiryDate,
					PolicyNo = "NULL",
					TransactionStatus = "NULL",
					AcceptanceNo = 2375033
				};

				var responseData = new ProformaResponseData
				{
					Output = outputData,
					ThirdPartyPremium = model.PremiumDetails.NetPayablePremium,
					NetPremium = model.PremiumDetails.NetPayablePremium,
					Stamp = model.PremiumDetails.StampDuty,
					VatablePremium = model.PremiumDetails.NetPayablePremium,
					VatAmount = model.PremiumDetails.VatAmt,
					TotalPayablePremium = model.PremiumDetails.TotalPayablePremium
				};

				var response = new ProformaResponse
				{
					ResponseCode = "0",
					ResponseMessage = "Success",
					TotalRecord = null,
					data = responseData
				};
				var response1 = new ProformaResponse1
				{
					ResponseCode = "0",
					ResponseMessage = "Success",
					TotalRecord = null,
					data = response
				};

				return Ok(response1);
			}
			catch (Exception ex)
			{
				return Ok(new { responseCode = "1", responseMessage = ex.Message });
			}
		}*/

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        [Route("PostMotor")]
        public async Task<IActionResult> PostMotor([FromBody] SaveMotorProforma model)
        {
			int kycDetailsId = 0;
            try
            {
                kycDetailsId = await _commonService.InsertKYCDetails(model.kycDetails);
                var merchantID = $"{_config["NLGApiURL:MerchantId"]}";

                model.MotorDetails.KycId = kycDetailsId;
                model.PremiumDetails.KycId = kycDetailsId;
                model.CommonPolicyDetails.KycId = kycDetailsId;

                if (model.kycDetails.Photos != null)
                {
                    foreach (var photo in model.kycDetails.Photos)
                        photo.KycId = kycDetailsId;
                }

                if (model.MotorDetails.ProductAttachments != null)
                {
                    foreach (var attachment in model.MotorDetails.ProductAttachments)
                        attachment.KycId = kycDetailsId;
                }

                await _commonService.InsertCommonPolicyDetails(model.CommonPolicyDetails);

                if (model.kycDetails.Photos?.Any() == true)
                    await _commonService.InsertPhoto(model.kycDetails.Photos);

                await _commonService.InsertMotorDetails(model.MotorDetails);
                await _commonService.InsertPremiumDetail(model.PremiumDetails);

				model.TransactionDetails.MERCHANTTRANSNO = $"{merchantID}-{kycDetailsId}";
				model.TransactionDetails.KycId = kycDetailsId;


                //await _commonService.InsertTransactionDetails(model.TransactionDetails);

                if (model.MotorDetails.ProductAttachments?.Any() == true)
                    await _commonService.InsertProductAttachment(model.MotorDetails.ProductAttachments);

                await _commonService.InsertTransactionDetails(model.TransactionDetails);

                var insurerId = 2;
                var insurer = await _commonService.GetInsurers(insurerId);

                var response = await httpapi.PostMotorProforma(
                    "/API/Motor/SaveMotorProforma",
                    insurer,
                    model);

                if (response?.Data?.Output?.Flag?.Equals("SUCCESS", StringComparison.OrdinalIgnoreCase) == true)
                {
                    response.MerchantTxnId = $"{merchantID}-{kycDetailsId}";

                    await _commonService.InsertMotorProforma(
                        response.Data.Output,
                        model,
                        kycDetailsId);
                }
                else
                {
                    await _commonService.InsertFailedMotorProforma(
                        model,
                        response?.Data?.Output?.SuccFailMsg ?? "Unknown error from insurer API",
						kycDetailsId);
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                await _commonService.InsertFailedMotorProforma(
                    model,
                    ex.Message,
                    kycDetailsId);

                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    success = 0,
                    message = ex.Message
                });
            }
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("previewPolicy")]
        public async Task<IActionResult> PreviewPolicy([FromBody] PreviewPolicyRequest model)
        {
            try
            {
                var insurerId = 2;
                var data = await _commonService.GetInsurers(insurerId);
                var preview = await httpapi.PreviewPolicyAsync("/api/Reports/PreviewPolicy", data, model.acceptanceNo);

                return Ok(preview);
            }
            catch (Exception ex)
            {
                return Ok(new { success = 0, message = ex.Message });
            }
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("getMerchantPaymentSource")]
        public async Task<IActionResult> GetMerchantPaymentSource([FromBody] GetMerchantPaymentSourceRequest model)
        {
            try
            {
                var insurerId = 2;
                var data = await _commonService.GetInsurers(insurerId);
                var result = await httpapi.GetMerchantPaymentSource("/API/Utility/GetMerchantPaymentSource", data, model.MerchantId);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(new { success = 0, message = ex.Message });
            }
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("getPaymentInstrumentDetails")]
        public async Task<IActionResult> GetPaymentInstrumentDetails()
        {
            try
            {
                var result = await httpapi.GetPaymentInstrumentDetails();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(new { success = 0, message = ex.Message });
            }
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("getProcessId")]
        public async Task<IActionResult> GetProcess([FromBody] ProcessModel model)
        {
            try
            {
                var data = await httpapi.GetProcess(model);
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return Ok(new { success = 0, message = "An unexpected error occurred. Please try again later." });
            }
        }
        public class TokenRequestModel
		{
			public string Token { get; set; }
		}

		[HttpPost("verify")]
		public IActionResult VerifyToken([FromBody] TokenRequestModel request)
		{
			var token = request.Token;
			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.UTF8.GetBytes(_config["Jwt:Key"]);

			try
			{
				tokenHandler.ValidateToken(token, new TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(key),
					ValidateIssuer = false,
					ValidateAudience = false,
					ValidateLifetime = true
				}, out SecurityToken validatedToken);

				// If we reach this point, the token is valid
				return Ok(new { valid = true, message = "Token is valid" });
			}
			catch (Exception ex)
			{
				// Token is invalid or expired
				return BadRequest(new { valid = false, message = ex.Message });
			}
		}
	}
}
