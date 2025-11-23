namespace NeoInsurance.Web.Model.Mobile.ResponseModel
{
    public class VehicleCompany
    {
        public int id { get; set; } 
        public string engName { get; set; } 
        public int classId { get; set; }   


    }
    public class VehicleModels
    {
        public int id { get; set; }
        public string engName { get; set; }
        public int companyId { get; set; }
    }
    public class VehicleNameList
    {
        public int id { get; set; }
        public string engName { get; set; }
        public int categoryId { get; set; }


    }
}
