using System;

namespace Core
{
    public class SubCategory
    {
        public Int64 CompanyId { get; set; }
        public Int64 BranchId { get; set; }
        public Int64 StoreId { get; set; }
        public Int64 MainCategoryId { get; set; }
        public Int64 SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string ImageUrl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public virtual MainCategory MainCategory { get; set; }
        public virtual List<Products> Products { get; set; }

    }
}