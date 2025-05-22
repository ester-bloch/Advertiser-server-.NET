using Core.Models.Customers;
using Core.Models.Orders;
using Core.Repository.Customers;
using Core.Repository.Orders;
using Core.Services.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Orders
{
    public class OrderService: IOrderService
    {

        private readonly IOrderRepository IRepositoryInjection;
        public OrderService(IOrderRepository injection)
        {
            IRepositoryInjection = injection;
        }

        public Task<int> CreateAsync(Order item)
        {
            return IRepositoryInjection.CreateAsync(item);
        }

        public Task<int> DeleteAsync(int id)
        {
            return IRepositoryInjection.DeleteAsync(id);
        }
        public Task<List<Order>> GetAllAsync()
        {
            return IRepositoryInjection.GetAllAsync();
        }

        public Task<Order> GetByIdAsync(int id)
        {
            return IRepositoryInjection.GetByIdAsync(id);
        }

        public Task<int> UpdateAsync(Order item)
        {
            return IRepositoryInjection.UpdateAsync(item);
        }

    }
}
