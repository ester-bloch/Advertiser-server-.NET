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
    public  class OrderCustomerService:IOrderCustomerService
    {
        private readonly IOrderCustomerRepository IRepositoryInjection;
        public OrderCustomerService(IOrderCustomerRepository injection)
        {
            IRepositoryInjection = injection;
        }

        public Task<int> CreateAsync(OrderCustomer item)
        {
            return IRepositoryInjection.CreateAsync(item);
        }

        public Task<int> DeleteAsync(int id)
        {
            return IRepositoryInjection.DeleteAsync(id);
        }
        public Task<List<OrderCustomer>> GetAllAsync()
        {
            return IRepositoryInjection.GetAllAsync();
        }

        public Task<OrderCustomer> GetByIdAsync(int id)
        {
            return IRepositoryInjection.GetByIdAsync(id);
        }

        public Task<int> UpdateAsync(OrderCustomer item)
        {
            return IRepositoryInjection.UpdateAsync(item);
        }
    }
}
