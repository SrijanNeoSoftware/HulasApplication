using System.Collections.Generic;
using System;

namespace HulasApplication.Model.MotorApi
{
	public class KycApplicantModel
	{
		public string CATEGORYID { get; set; }
		public string INSUREDTYPE { get; set; }
		public string kycclassification { get; set; }
		public string KYCRiskCategory { get; set; }
		public string INSUREDNAME_ENG { get; set; }
		public string INSUREDNAME_NEP { get; set; }
		public string ZONEID { get; set; }
		public string DISTRICTID { get; set; }
		public string MUNICIPALITYCODE { get; set; }
		public string VDCCODE { get; set; }
		public string ADDRESS { get; set; }
		public string ADDRESSNEPALI { get; set; }
		public string WARDNO { get; set; }
		public string HOUSENO { get; set; }
		public string PLOTNO { get; set; }
		public string TEMPORARYADDRESS { get; set; }
		public string NTEMPORARYADDRESS { get; set; }
		public string HOMETELNO { get; set; }
		public string MOBILENO { get; set; }
		public string EMAIL { get; set; }
		public string OCCUPATION { get; set; }
		public string INCOMESOURCE { get; set; }
		public string PANNO { get; set; }
		public string GENDER { get; set; }
		public string MARITALSTATUS { get; set; }
		public string DATEOFBIRTH { get; set; }
		public string CITIZENSHIPNO { get; set; }
		public string ISSUE_DISTRICT_ID { get; set; }
		public string ISSUEDATE { get; set; }
		public string FATHERNAME { get; set; }
		public string MOTHERNAME { get; set; }
		public string GRANDFATHERNAME { get; set; }
		public string GRANDMOTHERNAME { get; set; }
		public string HUSBANDNAME { get; set; }
		public string NFATHERNAME { get; set; }
		public string NGRANDFATHERNAME { get; set; }
		public string WIFENAME { get; set; }
		public string BRANCHCODE { get; set; }
		public string KYCNO { get; set; }
		public string ACCOUNTNAMECODE { get; set; }
		public string AREAID { get; set; }
		public string TOLEID { get; set; }
		public string USERID { get; set; }
		// public string Files { get; set; }
	}

	public class kycFormData
	{
		public KycApplicantModel[] KYCDetails { get; set; }
		public string Files { get; set; }
	}
	public class KycApplicanobject
	{
		public int response_code { get; set; }
		public string response_message { get; set; }
		public string response_description { get; set; }
		public KycIdData data { get; set; }
	}

	public class KycIdData
	{
		public string KYCNO { get; set; }
		public int KYCID { get; set; }
	}

	public class VerifyKhaltiPayment
	{
		public string token { get; set; }
		public int amount { get; set; }
	}


	public class VerifyKhaltiPaymentObj
	{
		public string idx { get; set; }
		public Type type { get; set; }
		public State state { get; set; }
		public int amount { get; set; }
		public int fee_amount { get; set; }
		public bool refunded { get; set; }
		public DateTime created_on { get; set; }
		public object ebanker { get; set; }
		public User user { get; set; }
		public Merchant merchant { get; set; }
	}

	public class Type
	{
		public string idx { get; set; }
		public string name { get; set; }
	}

	public class State
	{
		public string idx { get; set; }
		public string name { get; set; }
		public string template { get; set; }
	}

	public class User
	{
		public string idx { get; set; }
		public string name { get; set; }
		public string mobile { get; set; }
	}

	public class Merchant
	{
		public string idx { get; set; }
		public string name { get; set; }
		public string mobile { get; set; }
	}


	public class CellPayVerifyModel
	{
		public bool status { get; set; }
		public CellPayError[] errors { get; set; }
		public Payload payload { get; set; }
	}

	public class Payload
	{
		public Transactiondata transactionData { get; set; }
	}

	public class Transactiondata
	{
		public string status { get; set; }
		public string tranId { get; set; }
		public object traceNumber { get; set; }
		public string tranDate { get; set; }
		public string tranAmount { get; set; }
		public string totalAmount { get; set; }
		public string thirdPartyTranId { get; set; }
		public string invoiceNumber { get; set; }
		public object message { get; set; }
	}

	public class CellPayError
	{
		public string shortMessage { get; set; }
		public string longMessage { get; set; }
	}

	public class BankNameModel
	{
		public int total_records { get; set; }
		public int response_code { get; set; }
		public List<BankList> data { get; set; }
	}

	public class BankList
	{
		public string CLIENTCODE { get; set; }
		public string ECLIENTNAME { get; set; }
		public string ID { get; set; }
	}


	public class BankBranchModel
	{
		public int total_records { get; set; }
		public int response_code { get; set; }
		public BankBranchList[] data { get; set; }
	}

	public class BankBranchList
	{
		public string CLIENTCODE { get; set; }
		public string ECLIENTNAME { get; set; }
		public int id { get; set; }
	}
	public class BankBranchListModel
	{
		public string CLIENTCODE { get; set; }
		public string ECLIENTNAME { get; set; }
		public int id { get; set; }
		public string BankId { get; set; }
	}


	public class VehicleList
	{
		public int total_records { get; set; }
		public int response_code { get; set; }
		public string response_message { get; set; }
		public VehicleModel[] data { get; set; }
	}

	public class VehicleModel
	{
		public int ID { get; set; }
		public string ENGNAME { get; set; }
		public int VechicleManufactureId { get; set; }

	}
	public class GenerateSignatureModel
	{
		public string MerchantId { get; set; }
		public string MerchantName { get; set; }
		public string Amount { get; set; }
		public string MerchantTxnId { get; set; }
	}
	public class GetPaymentInstrumentDetailsModel
	{
		public string Code { get; set; }
		public string Message { get; set; }
		public List<ErrorModel> Errors { get; set; }
		public List<InstitutionModel> data { get; set; }

	}
	public class InstitutionModel
	{
		public string InstitutionName { get; set; }
		public string InstrumentName { get; set; }
		public string InstrumentCode { get; set; }
		public string InstrumentValue { get; set; }
		public string BankType { get; set; }
		public string LogoUrl { get; set; }
		public string BankUrl { get; set; }
	}
	public class ErrorModel
	{
		public string error_code { get; set; }
		public string error_message { get; set; }
	}
	public class GetService
	{
		public decimal Amount { get; set; }
		public string InstrumentCode { get; set; }
	}
	public class GetServiceModel
	{
		public string Code { get; set; }
		public string Message { get; set; }
		public List<ErrorModel> Errors { get; set; }
		public ServiceModel data { get; set; }
	}
	public class ServiceModel
	{
		public string Amount { get; set; }
		public string CommissionType { get; set; }
		public string ChargeValue { get; set; }
		public string TotalChargeAmount { get; set; }

	}
	public class ProcessModel
	{
		public decimal Amount { get; set; }
		public string MerchantTxnId { get; set; }
	}
	public class RedirectionModel
	{
		public decimal Amount { get; set; }
		public string MerchantTxnId { get; set; }
		public string ProcessId { get; set; }
		public string InstrumentCode { get; set; }
	}
	public class NPGResponseModel
	{
		public string MerchantTxnId { get; set; }
		public string ProcessId { get; set; }
		public string Amount { get; set; }
		public string GatewayTxnId { get; set; }
		public string Institution { get; set; }
		public string Status { get; set; }
		public string Instrument { get; set; }
		public string AcceptanceNo { get; set; }
		public string KYCID { get; set; }
	}
	public class GetProcess
	{
		public string Code { get; set; }
		public string Message { get; set; }
		public List<ErrorModel> Errors { get; set; }
		public ProcessIdModel data { get; set; }
	}
	public class ProcessIdModel
	{
		public string ProcessId { get; set; }
	}
	public class TransactionStatus
	{
		public string Code { get; set; }
		public string Message { get; set; }
		public string[] Errors { get; set; }
		public TransactionData Data { get; set; }
	}

	public class TransactionData
	{
		public string GatewayReferenceNo { get; set; }
		public decimal Amount { get; set; }
		public decimal ServiceCharge { get; set; }
		public string TransactionRemarks { get; set; }
		public string TransactionRemarks2 { get; set; }
		public string TransactionRemarks3 { get; set; }
		public string ProcessId { get; set; }
		public string TransactionDate { get; set; }
		public string MerchantTxnId { get; set; }
		public string CbsMessage { get; set; }
		public string Status { get; set; }
		public string Institution { get; set; }
		public string Instrument { get; set; }
		public string PaymentCurrency { get; set; }
		public decimal ExchangeRate { get; set; }
		public string AcceptanceNo { get; set; }
	}
	public class GatewayModel
	{
		public string GatewayReferenceNo { get; set; }
		public decimal Amount { get; set; }
		public decimal ServiceCharge { get; set; }
		public string TransactionRemarks { get; set; }
		public string TransactionRemarks2 { get; set; }
		public string TransactionRemarks3 { get; set; }
		public string ProcessId { get; set; }
		public DateTime TransactionDate { get; set; }
		public string MerchantTxnId { get; set; }
		public string CbsMessage { get; set; }
		public string Status { get; set; }
		public string Institution { get; set; }
		public string Instrument { get; set; }
		public string PaymentCurrency { get; set; }
		public decimal ExchangeRate { get; set; }
		public string AcceptanceNo { get; set; }

	}
	public class PolicyPurchase_Server
	{
		public int Id { get; set; }
		public string message { get; set; }
		public string draft_number { get; set; }
		public decimal cubic_capacity { get; set; }
		public string manufacture_company { get; set; }
		public decimal sum_insured { get; set; }
		public decimal third_party_premium { get; set; }
		public decimal basic_premium { get; set; }
		public decimal rsmdt_premium { get; set; }
		public decimal personal_accident_premium { get; set; }
		public decimal stamp_duty { get; set; }
		public decimal vat { get; set; }
		public decimal total_premium { get; set; }
		public string PolicyId { get; set; }
		public string PurchaseId { get; set; }
		public DateTime Createdate { get; set; }
		public string CreatedBy { get; set; }
		public string PaymentStatus { get; set; }
		public string PaymentMessage { get; set; }
		public string PaymentJson { get; set; }
	}

	public class VehicleInfo
	{
		public int CLASSID { get; set; }

		public int YEARMANUFACTURE { get; set; }

		public string? CCHP { get; set; }

		public int CATEGORYID { get; set; }

		public string? VehicleCost { get; set; }

		public int NCDYR { get; set; }

		public int CARRYCAPACITY { get; set; }

		public int NoOfSeat { get; set; }

		public int HasTrailor { get; set; }

		public int TrailorSi { get; set; }

		public int PrivateUse { get; set; }
		public string TypeCover { get; set; }
	}

	public class RiskData
	{
		public string? rskDesc { get; set; }
		public double rate { get; set; }
		public double amount { get; set; }
		public int catId { get; set; }
		public string? riskCode { get; set; }
		public int natPerils { get; set; }
		public int mot_risk_sno { get; set; }
		public int ignoreComm { get; set; }
		public int addMode { get; set; }
		public double rskSerialNo { get; set; }
	}

	public class HulasPremiumDetails
	{
		public double basicpremium { get; set; }
		public double poolpremium { get; set; }
		public double driverpremium { get; set; }
		public double helperpremium { get; set; }
		public double passengerpremium { get; set; }
		public double thirdpartypremium { get; set; }
		public double otherpremium { get; set; }
		public double netpremium { get; set; }
		public double stamp { get; set; }
		public double vatablepremium { get; set; }
		public double vatamount { get; set; }
		public double totalpayablepremium { get; set; }
	}

	public class GetQuoteApiResponse
	{
		public int requestId { get; set; }
		public int responseCode { get; set; }
		public string? responseMessage { get; set; }
		public string? amount { get; set; }
		public string? referenceCode { get; set; }
		public List<RiskData>? data { get; set; }
		public HulasPremiumDetails? premiumDetails { get; set; }
	}

	public class GetClassApiResponse
	{
		public int responseCode { get; set; }
		public string? responseMessage { get; set; }
		public string? totalRecord { get; set; }
		public List<GetClass>? data { get; set; }

	}

	public class GetClass
	{
		public int ID { get; set; }
		public string? CLASSCODE { get; set; }
		public string? DESCRIPTION { get; set; }
		public int ClassID { get; set; }
	}

	public class GetManufacturer
	{
		public int id { get; set; }
		public string? engName { get; set; }

	}
	public class GetManufacturerApiResponse
	{
		public int responseCode { get; set; }
		public string? responseMessage { get; set; }
		public string? totalRecord { get; set; }
		public List<GetManufacturer>? data { get; set; }

	}

	public class GetCategory
	{
		public int CATEGORYID { get; set; }
		public string? CATEGORYNAME { get; set; }
		public string? CalculationType { get; set; }
		public string? Carrying_Type { get; set; }
	}
	public class GetCategoryApiResponse
	{
		public int responseCode { get; set; }
		public string? responseMessage { get; set; }
		public string? totalRecord { get; set; }
		public List<GetCategory>? data { get; set; }

	}
	public class HulasCommonPolicyDetails
	{
		public int Id { get; set; }
		public int KycId { get; set; }
		public int ClassId { get; set; }
		public int ClientBankId { get; set; }
		public int BankBranchId { get; set; }
		public DateTime EffectiveDt { get; set; }
		public DateTime ExpiryDate { get; set; }
		public DateTime CreatedDate { get; set; }

	}

	public class HulasKYCDetails
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
		public string CurrentAddress { get; set; }
		public int DistrictId { get; set; }
		public string MunicipalityCode { get; set; }
		public string WardNo { get; set; }
		public string HouseNo { get; set; }
		public string MobileNo { get; set; }
		public string Email { get; set; }
		public string Panno { get; set; }
		public string FatherName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string CitizenshipNo { get; set; }
		public DateTime IssueDate { get; set; }
		public int IssueDistrictId { get; set; }
		public string MotherName { get; set; }
		public int MaritalStatus { get; set; }
		public string SpouseName { get; set; }
		public DateTime CreatedDate { get; set; }

		public List<HulasPhoto> Photos { get; set; }
	}

	public class HulasPhoto
	{
		public int KycId { get; set; }
		public int Id { get; set; }
		public string FileName { get; set; }
		public string KycImage { get; set; }
		public DateTime CreatedDate { get; set; }

	}

	public class HulasPremiumDetail
	{
		public int KycId { get; set; }
		public int Id { get; set; }
		public decimal NetPayablePremium { get; set; }
		public decimal StampDuty { get; set; }
		public decimal VatRate { get; set; }
		public decimal VatAmt { get; set; }
		public decimal TotalPayablePremium { get; set; }
		public DateTime CreatedDate { get; set; }

	}

	public class HulasMotorDetails
	{
		public int KycId { get; set; }
		public int Id { get; set; }
		public string YearManufacture { get; set; }
		public string CCHP { get; set; }
		public string TypeCover { get; set; }
		public int CategoryId { get; set; }
		public string VehicleCost { get; set; }
		public string EodAmt { get; set; }
		public int NcYr { get; set; }
		public int IncludeTowing { get; set; }
		public int IsGovernment { get; set; }
		public int ExcludePool { get; set; }
		public int ManufactureCompanyId { get; set; }
		public int HasTrailor { get; set; }
		public int CompanyVehicleModelId { get; set; }
		public int VehicleFormationId { get; set; }
		public int CarryCapacity { get; set; }
		public DateTime RegDate { get; set; }
		public string VehicleNoEnglish { get; set; }
		public string RunningVehicleNoEnglish { get; set; }
		public string EngineNo { get; set; }
		public string ChasisNo { get; set; }
		public int NoOfEmployee { get; set; }
		public int NoOfSeat { get; set; }
		public int TrailorSI { get; set; }
		public string TrailorSIDesc { get; set; }
		public DateTime CreatedDate { get; set; }
		public List<HulasProductAttachment> ProductAttachments { get; set; }
	}

	public class HulasProductAttachment
	{
		public int KycId { get; set; }
		public int Id { get; set; }
		public string DocumentName { get; set; }
		public string DocumentFile { get; set; }
		public DateTime CreatedDate { get; set; }
	}

	public class HulasPolicy
	{
		public HulasCommonPolicyDetails CommonPolicyDetails { get; set; }
		public HulasKYCDetails KycDetails { get; set; }
		public HulasPremiumDetail PremiumDetails { get; set; }
		public HulasMotorDetails MotorDetails { get; set; }
	}

	public class ProformaOutput
	{
		public string Flag { get; set; }
		public string SuccFailMsg { get; set; }
		public string ProformaNo { get; set; }
		public string Insured { get; set; }
		public string ClassName { get; set; }
		public string KycNo { get; set; }
		public string KycId { get; set; }
		public decimal SumInsured { get; set; }
		public decimal TpPremium { get; set; }
		public string DocumentNo { get; set; }
		public string ReceiptNo { get; set; }
		public string ReceiptDate { get; set; }
		public DateTime EffectiveDate { get; set; }
		public DateTime ExpiryDate { get; set; }
		public string PolicyNo { get; set; }
		public string TransactionStatus { get; set; }
		public int AcceptanceNo { get; set; }
	}

	public class ProformaResponseData
	{
		public ProformaOutput Output { get; set; }
		public decimal ThirdPartyPremium { get; set; }
		public decimal NetPremium { get; set; }
		public decimal Stamp { get; set; }
		public decimal VatablePremium { get; set; }
		public decimal VatAmount { get; set; }
		public decimal TotalPayablePremium { get; set; }
	}

	public class ProformaResponse
	{
		public string ResponseCode { get; set; }
		public string ResponseMessage { get; set; }
		public object TotalRecord { get; set; }
		public ProformaResponseData data { get; set; }
	}
	public class ProformaResponse1
	{
		public string ResponseCode { get; set; }
		public string ResponseMessage { get; set; }
		public object TotalRecord { get; set; }
		public ProformaResponse data { get; set; }
	}
	public class GetAToken
	{
		public string UserName { get; set; }
		public string Password { get; set; }
	}
	public class VehicleModelRequest
	{
		public int MakeVehicleCompanyId { get; set; }
	}
	public class getvehiclenamelist
	{
		public int CategoryId { get; set; }
	}
	public class getManufacture
	{
		public int classId { get; set; }
	}



	public class getDistrict
	{
		public int provinceId { get; set; }
	}

	public class getMnu
	{
		public int districtId { get; set; }
	}


    public class KycDetail
    {
        public int Id { get; set; }
        public int KycId { get; set; }
        public string UserId { get; set; }
        public int InsuredType { get; set; }
        public string Name { get; set; }
        public string NameNepali { get; set; }
        public string InsuredTypeName { get; set; }
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string MunicipalityCode { get; set; }
        public string Municipality { get; set; }
        public int WardNo { get; set; }
        public string HouseNo { get; set; }
        public string CurrentAddress { get; set; }
        public string AddressNepali { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string OccupationName { get; set; }
        public string IncomeSource { get; set; }
        public string PanNo { get; set; }
        public string FatherName { get; set; }
        public string FatherNameNep { get; set; }
        public string GrandFatherName { get; set; }
        public string GrandFatherNameNep { get; set; }
        public string MotherName { get; set; }
        public string MotherNameNep { get; set; }
        public string GrandMotherName { get; set; }
        public string SpouseName { get; set; }
        public string DateOfBirth { get; set; }
        public string CitizenshipNo { get; set; }
        public string IssueDate { get; set; }
        public int IssueDistrictID { get; set; }
        public string IssueDistrict { get; set; }
        public string Gender { get; set; }
        public string GenderName { get; set; }
        public string MaritalStatus { get; set; }
        public string MaritalStatusName { get; set; }
        public int KycRiskCategory { get; set; }
        public int KycClassification { get; set; }
        public string FileName { get; set; }
        public List<KycPhoto> Photos { get; set; }
        public string FAMILY_TYPE { get; set; }
        public string BuyerId { get; set; }
        public string Nominee { get; set; }
        public string NomineeRelation { get; set; }


    }

    public class KycPhoto
    {
        public int Id { get; set; }
        public int KycId { get; set; }
        public string FileName { get; set; }
        public string KycImage { get; set; }
        public string? FileUrl { get; set; }
    }
    public class CommonPolicyDetails
    {
        public int IsShortPolicy { get; set; }
        public int KycId { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int clientBankId { get; set; }
        public string ClientBankName { get; set; }
        public int bankBranchId { get; set; }
        public string bankBranceName { get; set; }
        public DateTime EffectiveDt { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int HASAGENT { get; set; }
        public string AgentCode { get; set; }
        public string fieldOfficerCode { get; set; }
        public int CategoryId { get; set; }
        public string CareOf { get; set; }

    }

    public class TransactionDetails
    {
        public string MERCHANTTRANSNO { get; set; }
        public int KycId { get; set; }
        public string GatewayTxnId { get; set; }
        public string Status { get; set; }
        public decimal PAIDAMT { get; set; }
        public int MerchantPaymentId { get; set; }
        public string MerchantPayment { get; set; }
        public string PaymentRemarks { get; set; }
        public int Id { get; set; }
    }
    public class ProductAttachment
    {
        public string DocumentName { get; set; }
        public int KycId { get; set; }

        public string DocumentFile { get; set; }
        public string? DocumentUrl { get; set; }
        public int MotorId { get; set; }
        public int Id { get; set; }
    }

    public class PremiumDetails
    {
        public decimal NetPayablePremium { get; set; }
        public int KycId { get; set; }

        public int StampDuty { get; set; }
        public int VATRATE { get; set; }
        public decimal VATAMT { get; set; }
        public decimal TotalPayablePremium { get; set; }
        public int MotorId { get; set; }
    }
    public class MotorDetails
    {
        public int Id { get; set; }
        public string YEARMANUFACTURE { get; set; }
        public int KycId { get; set; }
        public string CCHP { get; set; }
        public string TYPECOVER { get; set; }
        public int CATEGORYID { get; set; }
        public string Category { get; set; }
        public string VehicleCost { get; set; }
        public string UtilitiesCost { get; set; }
        public string EODAMT { get; set; }
        public int NCDYR { get; set; }
        public int DEPTID { get; set; }
        public string DEPT { get; set; }
        public int INCLUDETOWING { get; set; }
        public int ISGOVERNMENT { get; set; }
        public int EXCLUDEPOOL { get; set; }
        public int BUSSOCCPCODE { get; set; }
        public string MODEUSE { get; set; }
        public int ManufactureCompanyId { get; set; }
        public string ManufactureCompanyName { get; set; }
        public int HASTRAILOR { get; set; }
        public int CompanyVehicleModelId { get; set; }
        public string CompanyVehicleName { get; set; }
        public int VehicleFormationId { get; set; }
        public string VehicleFormation { get; set; }
        public int CARRYCAPACITY { get; set; }
        public string REGDATE { get; set; }
        public string VehicleNoNepali { get; set; }
        public string VehicleNoEnglish { get; set; }
        public string RunningVehicleNoNepali { get; set; }
        public string RunningVehicleNoEnglish { get; set; }
        public string ENGINENO { get; set; }
        public string CHASISNO { get; set; }
        public int NoOfEmployee { get; set; }
        public int NoOfSeat { get; set; }
        public int TrailorSI { get; set; }
        public string TrailorSIDesc { get; set; }
        public int SHOWROOM { get; set; }
        public List<ProductAttachment> ProductAttachments { get; set; }
        public string CreatedBy { get; set; }
        public int ClassId { get; set; }

        public string PolicyStatus { get; set; }
        public bool IsAllowed { get; set; }
        public string PolicyMessage { get; set; }
    }
    public class SaveMotorProforma
    {
        public KycDetail kycDetails { get; set; }
        public MotorDetails MotorDetails { get; set; }
        public PremiumDetails PremiumDetails { get; set; }
        public TransactionDetails TransactionDetails { get; set; }
        public CommonPolicyDetails CommonPolicyDetails { get; set; }
    }

    public class ResponseObject1
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public object TotalRecord { get; set; }
        public DataObject1 Data { get; set; }
        public string MerchantTxnId { get; set; }
    }

    public class DataObject1
    {
        public OutputObject1 Output { get; set; }
        public decimal BasicPremium { get; set; }
        public decimal PoolPremium { get; set; }
        public decimal DriverPremium { get; set; }
        public decimal HelperPremium { get; set; }
        public decimal PassengerPremium { get; set; }
        public decimal ThirdPartyPremium { get; set; }
        public decimal OtherPremium { get; set; }
        public decimal NetPremium { get; set; }
        public string Stamp { get; set; }
        public decimal VatablePremium { get; set; }
        public decimal VatAmount { get; set; }
        public decimal TotalPayablePremium { get; set; }
    }
    public class OutputObject1
    {
        public string Flag { get; set; }
        public string SuccFailMsg { get; set; }
        public string ProformaNo { get; set; }
        public string Insured { get; set; }
        public string ClassName { get; set; }
        public string KycNo { get; set; }
        public string KycId { get; set; }
        public decimal SumInsured { get; set; }
        public decimal TpPremium { get; set; }
        public string DocumentNo { get; set; }
        public string ReceiptNo { get; set; }
        public string ReceiptDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string PolicyNo { get; set; }
        public string TransactionStatus { get; set; }
        public string AcceptanceNo { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string VehicleNumber { get; set; }
    }

    public class PreviewPolicyRequest
    {
        public string acceptanceNo { get; set; }
    }

    public class MerchantBalanceResponse
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public object TotalRecord { get; set; }
        public BalanceData Data { get; set; }
    }

    public class GetMerchantPaymentSourceRequest
    {
        public int MerchantId { get; set; }
    }

    public class GetMerchantPaymentSourceResponse
    {
        public string responseCode { get; set; }
        public string responseMessage { get; set; }
        public int? totalRecord { get; set; }
        public List<MerchantPaymentSourceData> data { get; set; }
    }

    public class MerchantPaymentSourceData
    {
        public int id { get; set; }
        public string paymentSource { get; set; }
    }
    public class BalanceData
    {
        public decimal BalanceAmount { get; set; }
    }

}
