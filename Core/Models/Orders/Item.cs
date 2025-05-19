using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Orders
{
    public enum enumType
    {
        הדפסה, תליה, הפצה
    }
    public enum enumSize
    {
        A2, A3, A4, A5
    }
    public class Item
    {
        public int Id { get; set; }
        public enumType Type { get; set; }
        public enumSize Size { get; set; }
        public float MinPrice { get; set; }
        public float MaxPrice { get; set; }
    }
}
