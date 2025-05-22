using Core.Models.Customers;
using Core.Models.Orders;
using Core.Repository;
using Core.Repository.Customers;
using Core.Services.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Orders
{
    public class ItemService:IItemService
    {

        private readonly IItemRepository IRepositoryInjection;
        public ItemService(IItemRepository injection)
        {
            IRepositoryInjection = injection;
        }

        public Task<int> CreateAsync(Item item)
        {
            return IRepositoryInjection.CreateAsync(item);
        }

        public Task<int> DeleteAsync(int id)
        {
            return IRepositoryInjection.DeleteAsync(id);
        }
        public Task<List<Item>> GetAllAsync()
        {
            return IRepositoryInjection.GetAllAsync();
        }

        public Task<Item> GetByIdAsync(int id)
        {
            return IRepositoryInjection.GetByIdAsync(id);
        }

        public Task<int> UpdateAsync(Item item)
        {
            return IRepositoryInjection.UpdateAsync(item);
        }

    }
}
