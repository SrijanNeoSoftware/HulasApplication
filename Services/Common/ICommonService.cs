using HulasApplication.Model;
using HulasApplication.Model.MotorApi;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HulasApplication.Services.Common
{
	public interface ICommonService
	{
		Task<Insurers> GetInsurers(int Id);
		Task<int> InsertCommonPolicyDetails(CommonPolicyDetails commonPolicyDetails);
		Task<int> InsertKYCDetails(KycDetail kycDetails);
		Task<bool> InsertPhoto(List<KycPhoto> photos);
		Task<int> InsertPremiumDetail(PremiumDetails premiumDetail);
		Task<int> InsertMotorDetails(MotorDetails motorDetails);
		Task<bool> InsertProductAttachment(List<ProductAttachment> productAttachments);
		Task<int> InsertMotorProforma(OutputObject1 apiResponse, SaveMotorProforma model,int kycDetailsId);
		Task<int> InsertFailedMotorProforma(SaveMotorProforma model, string failureReason);




    }
}
