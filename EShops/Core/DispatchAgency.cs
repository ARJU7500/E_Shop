using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DispatchAgency
    {
        public Int64 CompanyId { get; set; }
        public Int64 BranchId { get; set; }
        public Int64 StoreId { get; set; }
        public Int64 MainCategoryId { get; set; }
        public Int64 SubCategoryId { get; set; }
        public Int64 UserMasterId { get; set; }
        public Int64 DispatchAgencyId {get; set;}
        public string DispatchAgencyName { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string ContactPerson {get; set;}
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public virtual List<OrderDispatch> OrderDispatches { get; set; }
    }
}
