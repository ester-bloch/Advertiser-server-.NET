using Core.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.Customers
{
    public interface IContactCustomerRepository
    {
        Task<List<ContactCustomer>> GetAllAsync();
        Task<ContactCustomer> GetByIdAsync(int id);

        Task DeleteAsync(int id);
        Task Update(ContactCustomer item);
        Task Create(ContactCustomer item);
    }
}
