
using Core.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Customers
{
    public  interface IOrderCustomerService
    {
        Task<List<OrderCustomer>> GetAllAsync();
        Task<OrderCustomer> GetByIdAsync(int id);

        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(OrderCustomer item);
        Task<int> CreateAsync(OrderCustomer item);
    }
}
