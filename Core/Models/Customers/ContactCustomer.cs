using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Customers
{
    public class ContactCustomer:Customer
    {
        public string ContactMessage { get; set; }
        public EnumStatus status { get; set; }
        public enum EnumStatus
        {
            חדש, בטיפול, טופל
        }

    }
}
