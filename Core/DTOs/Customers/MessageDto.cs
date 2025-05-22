using Core.Models;
using Core.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.Customers
{
    public class MessageDto
    {
        public int Id { get; set; }
        public UserDto User {  get; set; }
        public string Status{ get; set; }
        public string? Message { get; set; }
        public string? ManagerComment {  get; set; }

    }
    
}
