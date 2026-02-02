using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class UserMaster
    {
        public Int64 CompanyId { get; set; }
        public Int64 BranchId { get; set; }
        public Int64 StoreId { get; set; }
        public Int64 UserMasterId { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string Number { get; set; }
        public string CurrentAddress { get; set; }
        public string ImageUrl { get; set; }
        public string Degination { get; set; }
        public string PermanentAddress { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
