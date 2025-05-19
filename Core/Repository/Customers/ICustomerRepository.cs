using Core.Models.Customers;
using Core.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.Customers
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);

        Task DeleteAsync(int id);
        Task Update(Customer item);
        Task Create(Customer item);
    }
}
