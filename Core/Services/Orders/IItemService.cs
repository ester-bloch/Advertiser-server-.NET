using Core.Models.Customers;
using Core.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Orders
{
    public  interface IItemService
    {
        Task<List<Item>> GetAllAsync();
        Task<Item> GetByIdAsync(int id);

        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(Item item);
        Task<int> CreateAsync(Item item);
    }
}
