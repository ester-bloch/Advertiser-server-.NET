using Core.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.Orders
{
    public interface IOrderItemRepository
    {
        Task<List<OrderItem>> GetAllAsync();
        Task<OrderItem> GetByIdAsync(int id);

        Task DeleteAsync(int id);
        Task Update (OrderItem item);
        Task Create (OrderItem item);

    }
}
