using Core.Models.Customers;
using Core.Models.Orders;
using Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Orders
{
    public class ItemRepository: IItemRepository
    {
        private readonly AdvertiserContext _dbContext;

        public ItemRepository(AdvertiserContext dbContext)
        {
            _dbContext = dbContext;

        }
        public Task<int> CreateAsync(Item item)
        {
            _dbContext.Items.Add(item);
            return _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(int id)
        {
            var Item = await _dbContext.Items.FindAsync(id);
            if (Item != null)
            {
                _dbContext.Items.Remove(Item);
                return await _dbContext.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<List<Item>> GetAllAsync()
        {
            return await _dbContext.Items.ToListAsync();
        }
        public async Task<Item> GetByIdAsync(int id)

        {
            return await _dbContext.Items.Where(Item => Item.Id == id).FirstOrDefaultAsync();

        }
        public async Task<int> UpdateAsync(Item item)
        {
            var Item = await _dbContext.Items.Where(x => x.Id == item.Id).FirstOrDefaultAsync();
            _dbContext.Entry(Item).CurrentValues.SetValues(item);
            return await _dbContext.SaveChangesAsync();

        }
    }
}
