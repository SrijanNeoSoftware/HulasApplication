using HulasApplication.Model;
using HulasApplication.Model.MotorApi;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HulasApplication.Services.Common
{
	public interface ICommonService
	{
		Task<Insurers> GetInsurers(int Id);
		Task<int> InsertCommonPolicyDetails(HulasCommonPolicyDetails commonPolicyDetails);
		Task<int> InsertKYCDetails(HulasKYCDetails kycDetails);
		Task<bool> InsertPhoto(List<HulasPhoto> photos);
		Task<int> InsertPremiumDetail(HulasPremiumDetail premiumDetail);
		Task<int> InsertMotorDetails(HulasMotorDetails motorDetails);
		Task<bool> InsertProductAttachment(List<HulasProductAttachment> productAttachments);


	}
}
