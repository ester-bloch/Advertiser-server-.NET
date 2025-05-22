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
    public class OrderItemService: IOrderItemService
    {

        private readonly IOrderItemRepository IRepositoryInjection;
        public OrderItemService(IOrderItemRepository injection)
        {
            IRepositoryInjection = injection;
        }

        public Task<int> CreateAsync(OrderItem item)
        {
            return IRepositoryInjection.CreateAsync(item);
        }

        public Task<int> DeleteAsync(int id)
        {
            return IRepositoryInjection.DeleteAsync(id);
        }
        public Task<List<OrderItem>> GetAllAsync()
        {
            return IRepositoryInjection.GetAllAsync();
        }

        public Task<OrderItem> GetByIdAsync(int id)
        {
            return IRepositoryInjection.GetByIdAsync(id);
        }

        public Task<int> UpdateAsync(OrderItem item)
        {
            return IRepositoryInjection.UpdateAsync(item);
        }

    }
}
