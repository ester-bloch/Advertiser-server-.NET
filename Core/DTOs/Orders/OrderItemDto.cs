using Core.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.Orders
{
    public class OrderItemDto
    {
        public int Id { get; set; }
        public enumType Type { get; set; }
        public enumSize Size { get; set; }
        public float MinPrice { get; set; }
        public float MaxPrice { get; set; }
        public int? Amount { get; set; }

    }
  
}
