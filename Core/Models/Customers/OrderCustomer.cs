using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Customers
{
    public class OrderCustomer:Customer
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public string Status { get; set; }
    }
}
