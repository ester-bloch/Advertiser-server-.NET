using Core.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Customers
{
    public interface IContactCustomerService
    {
        Task<List<ContactCustomer>> GetAllAsync();
        Task<ContactCustomer> GetByIdAsync(int id);

        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(ContactCustomer item);
        Task<int> CreateAsync(ContactCustomer item);
    }
}
