using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Services.Customers;
using Core.Repository.Customers;
using Core.Models.Customers;

namespace Services.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository IRepositoryInjection;
        public CustomerService(ICustomerRepository injection)
        {
            IRepositoryInjection = injection;
        }

        public Task<int> CreateAsync(Customer item)
        {
            return IRepositoryInjection.CreateAsync(item);
        }

        public Task<int> DeleteAsync(int id)
        {
            return IRepositoryInjection.DeleteAsync(id);
        }
        public Task<List<Customer>> GetAllAsync()
        {
            return IRepositoryInjection.GetAllAsync();
        }

        public Task<Customer> GetByIdAsync(int id)
        {
            return IRepositoryInjection.GetByIdAsync(id);
                }

        public Task<int> UpdateAsync(Customer item)
        {
            return IRepositoryInjection.UpdateAsync(item);
        }
    }
}
