using Core.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IItemRepository
    {
        Task<List<Item>> GetAllAsync();
        Task<Item> GetByIdAsync(int id);

        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(Item item);
        Task<int> CreateAsync(Item item);
    }
}
