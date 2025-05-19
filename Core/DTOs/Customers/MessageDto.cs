using Core.Models;
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
        public EnumStatus Status {  get; set; }
        public string? Message { get; set; }
        public string? ManagerComment {  get; set; }
    }
    public enum EnumStatus
    {
        חדש,בטיפול, טופל
    }
}
