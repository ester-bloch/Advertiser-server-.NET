using Core.Models.Customers;
using Core.Models.Orders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Orders
{
    public class OrderItemRepository
    {
        private readonly AdvertiserContext _dbContext;

        public OrderItemRepository(AdvertiserContext dbContext)
        {
            _dbContext = dbContext;

        }
        public Task<int> CreateAsync(OrderItem item)
        {
            _dbContext.OrderItems.Add(item);
            return _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(int id)
        {
            var OrderItem = await _dbContext.OrderItems.FindAsync(id);
            if (OrderItem != null)
            {
                _dbContext.OrderItems.Remove(OrderItem);
                return await _dbContext.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<List<OrderItem>> GetAllAsync()
        {
            return await _dbContext.OrderItems.ToListAsync();
        }
        public async Task<OrderItem> GetByIdAsync(int id)

        {
            return await _dbContext.OrderItems.Where(OrderItem => OrderItem.Id == id).FirstOrDefaultAsync();

        }
        public async Task<int> UpdateAsync(OrderItem item)
        {
            var OrderItem = await _dbContext.OrderItems.Where(x => x.Id == item.Id).FirstOrDefaultAsync();
            _dbContext.Entry(OrderItem).CurrentValues.SetValues(item);
            return await _dbContext.SaveChangesAsync();

        }
    }
}
