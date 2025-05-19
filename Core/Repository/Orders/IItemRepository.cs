using Core.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IOrderItemRepository
    {
        Task<List<Item>> GetAllAsync();
        Task<Item> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task Update(Item item);
        Task Create(Item item);
    }
}
