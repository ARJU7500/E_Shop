using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Order
    {
        public Int64 CompanyId { get; set; }
        public Int64 BranchId { get; set; }
        public Int64 StoreId { get; set; }
        public Int64 MainCategoryId { get; set; }
        public Int64 SubCategoryId { get; set; }
        public Int64 OrderId { get; set; }
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; }
        public Int64 UserMasterId { get; set; }
        public bool Paid { get; set; }
        public string OrderedBy { get; set; }
        public DateTime OrderedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public virtual List<OrderPayments> OrderPayments { get; set; }
        public virtual List<OrderDispatch> OrderDispatches { get; set; }

        public virtual List<OrderDetails> OrderDetails { get; set; }
    }
}
