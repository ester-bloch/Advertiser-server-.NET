using Core.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.Orders
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllAsync();
        Task<OrderItem> GetByIdAsync(int id);

        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(Order item);
        Task<int> CreateAsync(Order item);
    }
}
