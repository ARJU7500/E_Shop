using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class OrderDetails
    {
        public Int64 OrderId { get; set; }
        public Int64 OrderDetailsId { get; set; }
        public Int64 ProductId { get; set; }
        public Int64 Qunty { get; set; }
        public decimal OrderPrice { get; set; }
    }
}
