
using Core.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Customers
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);

        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(Customer item);
        Task<int> CreateAsync(Customer item);
    }
}
