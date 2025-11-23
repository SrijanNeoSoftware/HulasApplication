using HulasApplication.Model.MotorApi;
using System.Collections.Generic;
using System;
using NeoInsurance.Web.Model.Mobile;
using NeoInsurance.Web.Model.Mobile.ResponseModel;
using NeoInsurance.Web.Model.Mobile.ResponseModel.Kyc;

namespace HulasApplication.Model.Mobile.ResponseModel
{
    public class GetClass
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<Classes> data { get; set; }
    }
    public class GetCategory
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<Category> data { get; set; }
    }
    public class GetCoverType
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<CoverType> data { get; set; }
    }
    public class GetManuYear
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<ManuYear> data { get; set; }
    }
    public class GetVehicleCompany
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<VehicleCompany> data { get; set; }
    }
    public class GetVehicleModel
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<VehicleModels> data { get; set; }
    }
    public class GetVehicleName
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<VehicleNameList> data { get; set; }
    }
    public class GetOccupation
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<Occupation> data { get; set; }
    }
    public class GetClientBank
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<ClientBank> data { get; set; }
    }
    public class GetMerchantPaymentSource
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<MerchantPaymentSource> data { get; set; }
    }
    public class GetAdditionalPropertyLst
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<AdditionalProperty> data { get; set; }
    }
    public class GetClientBankAddress
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<ClientBankAddress> data { get; set; }
    }
    public class GetHousePremium
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public HousePremiumModel data { get; set; }
    }
    public class GetMaritalStatus
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<MaritalStatus> data { get; set; }
    }
    public class GetProvince
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<Province> data { get; set; }
    }
    public class GetDistrict
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<District> data { get; set; }
    }
    public class GetTole
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<Tole> data { get; set; }
    }
    public class GetMNU
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<MNU> data { get; set; }
    }
    public class GetKycCategory
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<KycCategory> data { get; set; }
    }
    public class GetInsuredType
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<InsuredType> data { get; set; }
    }
    public class GetRiskCategory
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<RiskCategory> data { get; set; }
    }
    public class GetKycClassification
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<KycClassification> data { get; set; }
    }
    public class GetKycOccupation
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<KycOccupation> data { get; set; }

    }
    public class GetIncomeSource
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<IncomeSource> data { get; set; }
    }
    public class NLGResponse
    {
        public int Id { get; set; }
        public string Flag { get; set; }
        public string SuccFailMsg { get; set; }
        public string ProformaNo { get; set; }
        public string Insured { get; set; }
        public string ClassName { get; set; }
        public string KYCNo { get; set; }
        public string KYCID { get; set; }
        public decimal SumInsured { get; set; }
        public decimal TPPremium { get; set; }
        public string DocumentNo { get; set; }
        public string ReceiptNo { get; set; }
        public string ReceiptDate { get; set; }
        public string EffectiveDate { get; set; }
        public string ExpiryDate { get; set; }
        public string PolicyNo { get; set; }
        public string TransactionStatus { get; set; }
        public string AcceptanceNo { get; set; }
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
        public decimal VATAmount { get; set; }
        public decimal TotalPayablePremium { get; set; }
        public string NLGKycID { get; set; }
        public string MerchantTxnId { get; set; }
        public int? MotorId { get; set; }
        public int? CommonDetailId { get; set; }
        public int? PremiumDetailId { get; set; }
        public int? TransactionDetailId { get; set; }
        public string RequestJson { get; set; }
        public string PortfolioType { get; set; }
        public int HasLifeInsurance { get; set; }
        public string MetLifeApproved { get; set; }


    }
    public class FormModel
    {
        public string MerchantId { get; set; }
        public string MerchantName { get; set; }
        public string MerchantTxnId { get; set; }
        public string Amount { get; set; }
        public string ProcessId { get; set; }
        public string InstrumentCode { get; set; }
        public string TransactionRemarks { get; set; }
        public string URL { get; set; }

    }
    public class GetPolicyKYCDetails
    {
        public string KycId { get; set; }
        public string KycNo { get; set; }
        public string InsuredName { get; set; }
        public string NepTitle { get; set; }
        public string Zone { get; set; }
        public string District { get; set; }
        public string MnuVdc { get; set; }
        public string Address { get; set; }
        public string AddressNepali { get; set; }
        public string MobileNo { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string IncomeSource { get; set; }
        public string Occupation { get; set; }
        public string DateOfBirth { get; set; }
        public string CitizenShipNo { get; set; }
        public string PassportNo { get; set; }
        public string LicenseNo { get; set; }
    }

    public class ResponsePolicyDetails
    {
        public string PolicyNo { get; set; }
        public string DocumentNo { get; set; }
        public string FiscalYear { get; set; }
        public string ThirdPartyPremium { get; set; }
        public string VatAmt { get; set; }
        public string TpPremium { get; set; }
        public string AmtInWords_Eng { get; set; }
        public string AmtInWords_Nep { get; set; }
        public string DtPolicyIss { get; set; }
        public string PolicyRenewalDt { get; set; }
        public string ExpiryDt { get; set; }
        public string ReceiptNo { get; set; }
    }

    public class ResponseMotorDetails
    {
        public string CategoryName { get; set; }
        public string Typecover { get; set; }
        public string ModeUse { get; set; }
        public string VehicleNameId { get; set; }
        public string NameOfVehicle { get; set; }
        public string YearManufacture { get; set; }
        public string Cchp { get; set; }
        public string VehicleNo { get; set; }
        public string EngineNo { get; set; }
        public string ChasisNo { get; set; }
        public string BillBookTransferDate { get; set; }
        public string MotorId { get; set; }
        public int NoOfPassenger { get; set; }
        public int PassCapacity { get; set; }
        public int CarryCapacity { get; set; }
        public double EodAmt { get; set; }
    }

    public class RiskTypes
    {
        public string RiskDescription { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
    }

    public class ResponsePremiumDetails
    {
        public double SumInsured { get; set; }
        public double VatRate { get; set; }
        public double VatAmt { get; set; }
        public double BasicPremium { get; set; }
        public double ThirdPartyPremium { get; set; }
        public double OtherPremium { get; set; }
        public double PoolPremium { get; set; }
        public double DriverPremium { get; set; }
        public double PassengerPremium { get; set; }
        public double HelperPremium { get; set; }
        public double RsdPremium { get; set; }
        public int StampDuty { get; set; }
        public double NetPremium { get; set; }
        public double TotalPayablePrem { get; set; }
    }

    public class Data
    {
        public List<GetPolicyKYCDetails> KycDetails { get; set; }
        public List<ResponsePolicyDetails> PolicyDetails { get; set; }
        public List<ResponseMotorDetails> MotorDetails { get; set; }
        public List<RiskTypes> RiskTypes { get; set; }
        public List<ResponsePremiumDetails> PremiumDetails { get; set; }
    }

    public class InsuranceResponse
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string TotalRecord { get; set; }
        public Data Data { get; set; }
    }
    public class PreviewResponse
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string TotalRecord { get; set; }
        public string Data { get; set; }
    }

    public class NLGMakePayment
    {
        public string AcceptanceNo { get; set; }
        public string MerchantTransNo { get; set; }
        public string TransDate { get; set; }
        public decimal PaidAmt { get; set; }
        public int MerchantPaymentId { get; set; }
        public string PaymentRemarks { get; set; }
    }

    public class NLGMakePaymentResponse
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public int? TotalRecord { get; set; }
        public NLGMakePaymentData Data { get; set; }

    }
    public class NLGMakePaymentErrorResponse
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public int? TotalRecord { get; set; }
        public string Data { get; set; }
    }


    public class NLGMakePaymentData
    {
        public string Flag { get; set; }
        public string SuccFailMsg { get; set; }
        public string ProformaNo { get; set; }
        public string Insured { get; set; }
        public string ClassName { get; set; }
        public string Kycno { get; set; }
        public string Kycid { get; set; }
        public decimal SumInsured { get; set; }
        public decimal TpPremium { get; set; }
        public string DocumentNo { get; set; }
        public string ReceiptNo { get; set; }
        public string ReceiptDate { get; set; }
        public string EffectiveDate { get; set; }
        public string ExpiryDate { get; set; }
        public string PolicyNo { get; set; }
        public string TransactionStatus { get; set; }
        public int AcceptanceNo { get; set; }
        public bool? IsPurchased { get; set; }
    }

    public class GetCoverTypeModel
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<CoverTypeModel> data { get; set; }
    }

    public class GetPlanTypeModel
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<PlanTypeModel> data { get; set; }
    }

    public class GetForeignExchangeRates
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public ExchangeRateModel data { get; set; }
    }

    public class GetPackageTypeModel
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<PackageTypeModel> data { get; set; }
    }

    public class GetTMICovidCharge
    {
        public string responeCode { get; set; }
        public string responseMessage { get; set; }
        public string totalRecord { get; set; }
        public List<TMICovidCharge> data { get; set; }
    }
    public class TMIPremium
    {
        public int CoverId { get; set; }
        public int PlanId { get; set; }
        public int PackageId { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public int NoOfDays { get; set; }
        public string Currency { get; set; }
        public decimal CurrencyExcRate { get; set; }
        public int ClassId { get; set; }
        public int HasDirectDiscount { get; set; }
        public int IncludeCovidPremium { get; set; }
        public int IsAnnualTrip { get; set; }
        public int IncludeOneWayTripLoadingCharge { get; set; }
        public int IncludeLoadingCharge { get; set; }
        public int StampDuty { get; set; }
        public List<TMIMember> MemberList { get; set; }
    }
    public class TMIMember
    {
        public string MemberName { get; set; }
        public string MemberAddress { get; set; }
        public string PassportNo { get; set; }
        public int Age { get; set; }
        public string VisitPlace { get; set; }
        public string ContactNo { get; set; }
        public string Occupation { get; set; }
        public string Remarks { get; set; }
        public string CareOf { get; set; }
        public int Isdependent { get; set; }
        public string Relation { get; set; }

    }

    public class TMIMemberDetail
    {
        public string memberName { get; set; }
        public string memberAddress { get; set; }
        public string passportNo { get; set; }
        public int age { get; set; }
        public string visitPlace { get; set; }
        public string contactNo { get; set; }
        public string occupation { get; set; }
        public string remarks { get; set; }
        public string careOf { get; set; }
        public string isdependent { get; set; }
        public string relation { get; set; }
        public string currency { get; set; }
        public string currencyExchangeRate { get; set; }
        public string premiumInUSD { get; set; }
        public string premiumInNRS { get; set; }
        public decimal covidChargePremium { get; set; }
        public decimal oneWayTripAmount { get; set; }
        public decimal otherLoadingChargeAmount { get; set; }
        public decimal discountAmount { get; set; }

    }
    public class TMIPremiumDetail
    {
        public string currency { get; set; }
        public decimal currencyExchangeRate { get; set; }
        public decimal totalPremiumInUSD { get; set; }
        public decimal totalPremiumInNRS { get; set; }
        public decimal totalCovidChargePremium { get; set; }
        public decimal totalOneWayTripAmount { get; set; }
        public decimal totalOtherLoadingChargeAmount { get; set; }
        public decimal totalDiscountAmount { get; set; }
        public decimal netPremium { get; set; }
        public decimal stampDuty { get; set; }
        public decimal vatablePremium { get; set; }
        public decimal vatAmount { get; set; }
        public decimal totalPayablePremium { get; set; }
    }

    public class TMIDataResponse
    {
        public TMIPremiumDetail premCalc { get; set; }
        public List<TMIMemberDetail> memberList { get; set; }

    }
    public class TMIResponseModel
    {
        public string responseCode { get; set; }
        public string responseMessage { get; set; }
        public TMIDataResponse data { get; set; }
    }

    public class TMIResponseRoot
    {
        public string responseCode { get; set; }
        public string responseMessage { get; set; }
        public object totalRecord { get; set; }
        public ResponseData data { get; set; }
    }

    public class ResponseData
    {
        public InnerResponse response { get; set; }
        public decimal netPremium { get; set; }
        public decimal stampduty { get; set; }
        public decimal vatAmount { get; set; }
        public decimal totalPayablePremium { get; set; }
    }

    public class InnerResponse
    {
        public string responseMessage { get; set; }
        public string responseCode { get; set; }
        public object totalRecord { get; set; }
        public ProformaData data { get; set; }
    }

    public class ProformaData
    {
        public string flag { get; set; }
        public string succFailMsg { get; set; }
        public string proformaNo { get; set; }
        public string insured { get; set; }
        public string className { get; set; }
        public string kycno { get; set; }
        public string Kycid { get; set; }
        public decimal sumInsured { get; set; }
        public decimal tpPremium { get; set; }
        public string documentNo { get; set; }
        public string receiptNo { get; set; }
        public string receiptDate { get; set; }
        public string effectiveDate { get; set; }
        public string expiryDate { get; set; }
        public string policyNo { get; set; }
        public string transactionStatus { get; set; }
        public int acceptanceNo { get; set; }
    }
    public class OutputHome
    {
        public ProformaData output { get; set; }
    }

    public class HomeResponse
    {
        public string responseCode { get; set; }
        public string responseMessage { get; set; }
        public int? totalRecord { get; set; }
        public OutputHome data { get; set; }
    }

    public class HomeData
    {
        public ProformaData output { get; set; }
        public string MerchantTxnId { get; set; }
    }
    public class HomeRoot
    {
        public string responseCode { get; set; }
        public string responseMessage { get; set; }
        public int? totalRecord { get; set; }
        public HomeData data { get; set; }
    }
}
