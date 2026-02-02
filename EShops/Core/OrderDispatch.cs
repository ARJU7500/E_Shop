using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class OrderDispatch
    {
        public Int64 CompanyId { get; set; }
        public Int64 BranchId { get; set; }
        public Int64 StoreId { get; set; }
        public Int64 MainCategoryId { get; set; }
        public Int64 SubCategoryId { get; set; }
        public Int64 ProductsId { get; set; }
        public Int64 OrderDispatchId { get; set; }
        public DateTime DispatchDate { get; set; }
        public DateTime ExpetedReachDate { get; set; }
        public string DocketNo { get; set; }
        public virtual Order Order { get; set; }
        public virtual DispatchAgency DispatchAgency { get; set; }

        public Int64 DispatchAgencyId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
