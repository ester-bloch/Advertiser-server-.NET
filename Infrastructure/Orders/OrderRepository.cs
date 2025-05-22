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
    public class OrderRepository
    {
        private readonly AdvertiserContext _dbContext;

        public OrderRepository(AdvertiserContext dbContext)
        {
            _dbContext = dbContext;

        }
        public Task<int> CreateAsync(Order item)
        {
            _dbContext.Orders.Add(item);
            return _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(int id)
        {
            var Order = await _dbContext.Orders.FindAsync(id);
            if (Order != null)
            {
                _dbContext.Orders.Remove(Order);
                return await _dbContext.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<List<Order>> GetAllAsync()
        {
            return await _dbContext.Orders.ToListAsync();
        }
        public async Task<Order> GetByIdAsync(int id)

        {
            return await _dbContext.Orders.Where(Order => Order.Id == id).FirstOrDefaultAsync();

        }
        public async Task<int> UpdateAsync(Order item)
        {
            var Order = await _dbContext.Orders.Where(x => x.Id == item.Id).FirstOrDefaultAsync();
            _dbContext.Entry(Order).CurrentValues.SetValues(item);
            return await _dbContext.SaveChangesAsync();

        }
    }
}
