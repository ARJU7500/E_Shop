using System;

namespace Core
{
    public class MainCategory
    {
        public Int64 MainCategoryId { get; set; }
        public Int64 CompanyId { get; set; }
        public Int64 BranchId { get; set; }
        public Int64 StoreId { get; set; }
        public string MainCategoryName { get; set; }
        public string ImageUrl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public virtual List<SubCategory> SubCategories { get; set; }
    }
}