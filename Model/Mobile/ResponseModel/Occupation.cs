using System.Text.Json.Serialization;

namespace NeoInsurance.Web.Model.Mobile.ResponseModel
{
    public class Occupation
    {
        public int Id { get; set; }
        public string bussOccPCode { get; set; }
        public string description { get; set; }
    }
    public class ClientBank
    {
        public int ID { get; set; }
        public string BankName { get; set; }
    }
    public class MerchantPaymentSource
    {
        public int id { get; set; }
        public string paymentSource { get; set; }
    }

    public class AdditionalProperty
    {
        public int id { get; set; }
        public string EngDescription { get; set; }
        public string NepDescription { get; set; }

    }
    public class ClientBankAddress
    {
        public int id { get; set; }
        public string BankAddress { get; set; }
    }
    public class MaritalStatus
    {
        public int ID { get; set; }
        public string MritalStatus { get; set; }

    }
    public class HouseModel
    {
        public int HasAgent { get; set; }

        public string AgentCode { get; set; }
        public int InsuredId { get; set; }
        public decimal SumInsured { get; set; }
    }
    public class HousePremiumModel
    {
      
        public decimal PremiumAmount { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal BasicPremium { get; set; }

        public decimal PoolPremium { get; set; }

        public decimal NetPremium { get; set; }

        public decimal StampDuty { get; set; }

        public decimal SubTotal { get; set; }

        public decimal VatAmount { get; set; }

        public decimal TotalPremium { get; set; }
        public int VatRate { get; set; }
    }
}
