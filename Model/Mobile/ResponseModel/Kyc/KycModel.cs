using System;
using System.Collections.Generic;

namespace NeoInsurance.Web.Model.Mobile.ResponseModel.Kyc
{
    public class Province
    {
        public int provinceCode { get; set; }  
        public string eProvince { get; set; }
        public string nProvince { get; set; }
        
    }
    public class CoverTypeModel
    {
        public int id { get; set; }
        public string edesc { get; set; }

    }
    public class PlanTypeModel
    {
        public int id { get; set; }
        public string planType { get; set; }

    }
    public class ExchangeRateModel
    {
        public string currencyName { get; set; }
        public string countryCode { get; set; }
        public int unit { get; set; }
        public decimal buy { get; set; }
        public decimal sell { get; set; }

    }
    public class PackageTypeModel
    {
        public int id { get; set; }
        public string packageType { get; set; }

    }
    public class TMICovidCharge
    {
        public string keyName { get; set; }
        public string chargeInPercentage { get; set; }

    }
    public class District
    {
        public int id { get; set; }
        public string eDescription { get; set; }
        public string nDescription { get; set;}

    }
    public class Tole
    {
        public int toleId { get; set; }
        public int districtId { get; set; }
        public string eDesc{ get; set; }
        public string nDesc { get; set; }
    }
    public class MNU
    {

        public string mnuCode { get; set; }
        public string municipality { get; set; }
        public string municipalityNep { get; set; }
    }
    public class KycCategory
    {
        public int id { get; set; }
        public string groupName { get; set; }
    }
    public class InsuredType
    {
        public int insuredTypeId { get; set; }
        public string typeofInsured { get; set; }
    }
    public class RiskCategory
    {
        public int id { get; set; }
        public string description { get; set; }
    }
    public class KycClassification
    {
        public int id { get; set; }
        public string classificationName { get; set; }
        public string classificationName_Nep { get; set; }
        public int riskExposureId { get; set; }
        public string remarks { get; set; }
    }
    public class KycOccupation
    {
        public int bussOccpCode { get; set; }
        public string description { get; set; }
    }
    public class IncomeSource
    {
        public int bussOccpCode { get; set; }
        public string description { get; set; }
    }

    public class NLGPhotos
    {
        public string FileName { get; set; }
        public string KycImage { get; set; }
    }

    public class NLGKYCDetail
    {
        public int KycId { get; set; }
        public int INSUREDTYPE { get; set; }
        public int kycclassification { get; set; }
        public int KYCRiskCategory { get; set; }
        public string Name { get; set; }
        public string NameNepali { get; set; }
        public string GENDER { get; set; }
        public string CurrentADDRESS { get; set; }
        public string addressNepali { get; set; }
        public string DISTRICTID { get; set; }
        public string provinceId { get; set; }
        public string MunicipalityCode { get; set; }
        public string WARDNO { get; set; }
        public string HOUSENO { get; set; }
        public string MOBILENO { get; set; }
        public string EMAIL { get; set; }
        public string PANNO { get; set; }
        public string Occupation { get; set; }
        public string FATHERNAME { get; set; }
        public string GRANDFATHERNAME { get; set; }
        public string GRANDFATHERNAMENepali { get; set; }
        public string DATEOFBIRTH { get; set; }
        public string CITIZENSHIPNO { get; set; }
        public string ISSUEDATE { get; set; }
        public int ISSUEDISTRICTID { get; set; }
        public string incomeSource { get; set; }
        public string motherName { get; set; }
        public string maritalStatus { get; set; }
        public string spouseName { get; set; }
        public List<NLGPhotos> Photos { get; set; }
    }

    public class HomeKYCDetail
    {
        public int KycId { get; set; }
        public int insuredType { get; set; }
        public int kycclassification { get; set; }
        public int KycRiskCategory { get; set; }
        public string Name { get; set; }
        public string NameNepali { get; set; }
        public string gender { get; set; }
        public string CurrentADDRESS { get; set; }
        public string addressNepali { get; set; }
        public string districtId { get; set; }
        public string provinceId { get; set; }
        public string MunicipalityCode { get; set; }
        public string WARDNO { get; set; }
        public string HOUSENO { get; set; }
        public string MOBILENO { get; set; }
        public string EMAIL { get; set; }
        public string PANNO { get; set; }
        public string Occupation { get; set; }
        public string FATHERNAME { get; set; }
        public string GRANDFATHERNAME { get; set; }
        public string DATEOFBIRTH { get; set; }
        public string CITIZENSHIPNO { get; set; }
        public string ISSUEDATE { get; set; }
        public int ISSUEDISTRICTID { get; set; }
        public string incomeSource { get; set; }
        public string motherName { get; set; }
        public string maritalStatus { get; set; }
        public string spouseName { get; set; }
        public List<NLGPhotos> Photos { get; set; }
    }

    public class NLGTransactionDetail
    {
        public string MERCHANTTRANSNO { get; set; }
        public decimal PAIDAMT { get; set; }
        public int MerchantPaymentId { get; set; }
        public string PaymentRemarks { get; set; }
    }

    public class NLGPremiumDetail
    {
        public decimal NetPayablePremium { get; set; }
        public int StampDuty { get; set; }
        public int VATRATE { get; set; }
        public decimal VATAMT { get; set; }
        public decimal TotalPayablePremium { get; set; }
    }

    public class NLGMotorDetail
    {
        public string YEARMANUFACTURE { get; set; }
        public string CCHP { get; set; }
        public string TYPECOVER { get; set; }
        public int CATEGORYID { get; set; }
        public string VehicleCost { get; set; }
        public string UtilitiesCost { get; set; }
        public string EODAMT { get; set; }
        public int NCDYR { get; set; }
        public int DEPTID { get; set; }
        public int INCLUDETOWING { get; set; }
        public int ISGOVERNMENT { get; set; }
        public int EXCLUDEPOOL { get; set; }
        public int BUSSOCCPCODE { get; set; }
        public string MODEUSE { get; set; }
        public int ManufactureCompanyId { get; set; }
        public int HASTRAILOR { get; set; }
        public int CompanyVehicleModelId { get; set; }
        public int VehicleFormationId { get; set; }
        public int CARRYCAPACITY { get; set; }
        public string REGDATE { get; set; }
        public string VehicleNoNepali { get; set; }
        public string VehicleNoEnglish { get; set; }
        public string RunningVehicleNoNepali { get; set; }
        public string RunningVehicleNoEnglish { get; set; }
        public string ENGINENO { get; set; }
        public string CHASISNO { get; set; }
        public int NOOFEMPLOYEE { get; set; }
        public int NoOfSeat { get; set; }
        public int TrailorSI { get; set; }
        public string TrailorSIDesc { get; set; }
        public int SHOWROOM { get; set; }
        public List<NLGProductAttachment> ProductAttachments { get; set; }
    }

    public class NLGProductAttachment
    {
        public string DocumentName { get; set; }
        public string DocumentFile { get; set; }
    }

    public class NLGCommonPolicyDetails
    {
        public int IsShortPolicy { get; set; }
        public int DeptId { get; set; }
        public int ClassId { get; set; }
        public int clientBankId { get; set; }
        public int bankBranchId { get; set; }
        public DateTime EffectiveDt { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int HASAGENT { get; set; }
        public string AgentCode { get; set; }
        public string fieldOfficerCode { get; set; }
    }
    public class HomeCommonPolicyDetails
    {
        public int isShortPolicy { get; set; }
        public int ClassId { get; set; }
        public int CategoryID { get; set; }
        public int clientBankId { get; set; }
        public int bankBranchId { get; set; }
        public string EffectiveDt { get; set; }
        public string ExpiryDt { get; set; }
        public int hasAgent { get; set; }
        public string agentCode { get; set; }
    }

    public class MotorProforma
    {
        public NLGCommonPolicyDetails CommonPolicyDetails { get; set; }
        public NLGKYCDetail KYCDetails { get; set; }
        public NLGTransactionDetail TransactionDetails { get; set; }
        public NLGPremiumDetail PremiumDetails { get; set; }
        public NLGMotorDetail MotorDetails { get; set; }
    }

    public class HomeAddtionalProperty
    {
        public int Id { get; set; }
        public int KYCID { get; set; }
        public int propertyInsuredId { get; set; }
        public string propertyInsuredSI { get; set; }
        public string remarks { get; set; }
    }

    public class HomeAttachment
    {
        public int Id { get; set; }
        public int KYCID { get; set; }

        public string documentName { get; set; }
        public string documentFile { get; set; }
        public string? documentUrl { get; set; }
    }

    public class HomeDetail
    {
        public int Id { get; set; }
        public int KYCID { get; set; }
        public int provinceID { get; set; }
        public int districtID { get; set; }
        public int mnu { get; set; }
        public string wardNo { get; set; }
        public string houseNo { get; set; }
        public string plotNo { get; set; }
        public string tole { get; set; }
        public string ownerName { get; set; }
        public int numberOfFloors { get; set; }
        public decimal sumInsured { get; set; }
        public string UserID { get; set; }

    }

    public class APIHomeDetail
    {
        public int provinceID { get; set; }
        public int districtID { get; set; }
        public int mnu { get; set; }
        public string wardNo { get; set; }
        public string houseNo { get; set; }
        public string plotNo { get; set; }
        public string tole { get; set; }
        public string ownerName { get; set; }
        public int numberOfFloors { get; set; }
        public decimal sumInsured { get; set; }
        public List<APIHomeAttachment> Attachment { get;set;}
        public List<HomeAddtionalProperty> additionalPropertyLst { get;set;}
    }
    public class APIHomeAttachment
    {
        public string documentName { get; set; }
        public string documentFile { get; set; }
    }

    public class APIHomeAddtionalProperty
    {
        public int propertyInsuredId { get; set; }
        public string propertyInsuredSI { get; set; }
        public string remarks { get; set; }
    }

    public class HomeDetailModel
    {
        public int provinceID { get; set; }
        public int districtID { get; set; }
        public int mnu { get; set; }
        public string wardNo { get; set; }
        public string houseNo { get; set; }
        public string plotNo { get; set; }
        public string tole { get; set; }
        public string ownerName { get; set; }
        public int numberOfFloors { get; set; }
        public decimal sumInsured { get; set; }
        public string UserID { get; set; }
        public int KYCID { get; set; }

        public List<HomeAddtionalProperty> additionalProperties { get; set; }
        public List<HomeAttachment> homeAttachments { get; set; }
        public string ProvinceName { get; set; }
        public string DistrictName { get; set; }
        public string Municipality { get; set; }
    }

    public class TMICommonPolicy
    {
        public int KycId { get; set; }
        public int IsShortPolicy { get; set; }
        public int DeptId { get; set; }
        public int ClassId { get; set; }
        public DateTime EffectiveDt { get; set; }
        public DateTime ExpiryDate { get; set; }
    }

    public class TMIKYCDeail
    {
        public int KycId { get; set; }
        public int INSUREDTYPE { get; set; }
        public int kycclassification { get; set; }
        public int KYCRiskCategory { get; set; }
        public string Name { get; set; }
        public string NameNepali { get; set; }
        public string GENDER { get; set; }
        public string CurrentADDRESS { get; set; }
        public string ADDRESSNepali { get; set; }
        public string DISTRICTID { get; set; }
        public string provinceId { get; set; }
        public string MunicipalityCode { get; set; }
        public string WARDNO { get; set; }
        public string HOUSENO { get; set; }
        public string MOBILENO { get; set; }
        public string EMAIL { get; set; }
        public string PANNO { get; set; }
        public string Occupation { get; set; }
        public string FATHERNAME { get; set; }
        public string FATHERNAMENepali { get; set; }
        public string GRANDFATHERNAME { get; set; }
        public string GRANDFATHERNAMENepali { get; set; }
        public string DATEOFBIRTH { get; set; }
        public string CITIZENSHIPNO { get; set; }
        public string ISSUEDATE { get; set; }
        public int ISSUEDISTRICTID { get; set; }
        public List<NLGPhotos> Photos { get; set; }
    }

    public class TMITransactionDetails
    {
        public int KycId { get; set; }
        public string MerchantTransNo { get; set; }
        public DateTime TransDate { get; set; }
        public decimal PAIDAMT { get; set; }
        public int MerchantPaymentId { get; set; }
        public string PaymentRemarks { get; set; }

    }
    public class TMIPremiumDetails
    {
        public int KycId { get; set; }

        public decimal NetPayablePremium { get; set; }
        public decimal StampDuty { get; set; }
        public decimal VATRate { get; set; }
        public decimal VATAmt { get; set; }
        public decimal TotalPayablePremium { get; set; }
        public decimal PremiumRate { get; set; }
    }
    public class TMIDetails
    {
        public int KycId { get; set; }

        public int CoverId { get; set; }
        public int PlanId { get; set; }
        public int PackageId { get; set; }
        public int NoOfDays { get; set; }
        public int IsAnnualTrip { get; set; }
        public string Currency { get; set; }
        public decimal CurrencyExcRate { get; set; }
        public int HasDirectDiscount { get; set; }
        public int IncludeCovidPremium { get; set; }
        public int IncludeOneWayTripLoadingCharge { get; set; }
        public int IncludeLoadingCharge { get; set; }
        public List<APIHomeAttachment> productAttachments { get; set; }
        public List<TMIMemberList> MemberList { get; set; }
    }

    public class TMIMemberList
    {
        public string MemberName { get; set; }
        public string MemberAddress { get; set; }
        public string PassportNo { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string VisaNumber { get; set; }
        public string VisitPlace { get; set; }
        public string ContactNo { get; set; }
        public string Occupation { get; set; }
        public string Remarks { get; set; }
        public string CareOf { get; set; }
        public int Isdependent { get; set; }
        public string Relation { get; set; }
        public int KycId { get; set; }
        public int TravelId { get; set; }
    }

}
