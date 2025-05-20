using Core.Models.Customers;
using Core.Repository.Customers;
using Core.Services.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Customers
{
    public class ContactCustomerService : IContactCustomerService
    {

            private readonly IContactCustomerRepository IRepositoryInjection;
            public ContactCustomerService(IContactCustomerRepository injection)
            {
                IRepositoryInjection = injection;
            }

            public Task<int> CreateAsync(ContactCustomer item)
            {
                return IRepositoryInjection.CreateAsync(item);
            }

            public Task DeleteAsync(int id)
            {
                return IRepositoryInjection.DeleteAsync(id);
            }
            public Task<List<ContactCustomer>> GetAllAsync()
            {
                return IRepositoryInjection.GetAllAsync();
            }

            public Task<ContactCustomer> GetByIdAsync(int id)
            {
                return IRepositoryInjection.GetByIdAsync(id);
            }

            public Task UpdateAsync(ContactCustomer item)
            {
                return IRepositoryInjection.UpdateAsync(item);
            }

       
        Task<int> IContactCustomerService.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<int> IContactCustomerService.UpdateAsync(ContactCustomer item)
        {
            throw new NotImplementedException();
        }
    }
    }