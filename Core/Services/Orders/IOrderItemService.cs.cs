using Core.Models.Customers;
using Core.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Orders
{
    public interface IOrderItemService
    {

        Task<List<OrderItem>> GetAllAsync();
        Task<OrderItem> GetByIdAsync(int id);

        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(OrderItem item);
        Task<int> CreateAsync(OrderItem item);
    }
}
