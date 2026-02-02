using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class OrderPayments
    {
        public Int64 CompanyId { get; set; }
        public Int64 BranchId { get; set; }
        public Int64 StoreId { get; set; }
        public Int64 MainCategoryId { get; set; }
        public Int64 SubCategoryId { get; set; }
        public Int64 OrderId { get; set; }
        public Int64 ProductsId { get; set; }
        public Int64 OrderDetailsId { get; set; }
        public Int64 OrderPaymentsId { get; set; }
        public DateTime OrderPaymentDate { get; set; }
        public virtual Order Order { get; set; }
        public decimal Amount { get; set; }
        public PaymentModeEnum PaymentMode { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
