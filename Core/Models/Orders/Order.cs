using Core.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public OrderCustomer OrderCustomer { get; set; }
        public int OrderCustomerId { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public int SumToPay {  get; set; }
        public bool IsPaid { get; set; }
        public string Status {  get; set; }
    }
}
