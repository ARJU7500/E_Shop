using System;

namespace Core
{
    public class Store
    {
        public Int64 CompanyId { get; set; }
        public Int64 BranchId { get; set; }
        public Int64 StoreId { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string mobileNo { get; set; }
        public string WebsiteUrl {get; set;}
        //public string Password { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string ImageUrl { get; set; }
    }
}
