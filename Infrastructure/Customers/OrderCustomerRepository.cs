using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models.Customers;
using Core.Repository.Customers;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.OrderCustomers
{
    public class OrderCustomerRepository:IOrderCustomerRepository
    {
        private readonly AdvertiserContext _dbContext;

        public OrderCustomerRepository(AdvertiserContext dbContext)
        {
            _dbContext = dbContext;

        }
        public Task<int> CreateAsync(OrderCustomer item)
        {
            _dbContext.OrderCustomers.Add(item);
            return _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(int id)
        {
            var OrderCustomer = await _dbContext.OrderCustomers.FindAsync(id);
            if (OrderCustomer != null)
            {
                _dbContext.OrderCustomers.Remove(OrderCustomer);
                return await _dbContext.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<List<OrderCustomer>> GetAllAsync()
        {
            return await _dbContext.OrderCustomers.ToListAsync();
        }
        public async Task<OrderCustomer> GetByIdAsync(int id)

        {
            return await _dbContext.OrderCustomers.Where(OrderCustomer => OrderCustomer.Id == id).FirstOrDefaultAsync();

        }
        public async Task<int> UpdateAsync(OrderCustomer item)
        {
            var OrderCustomer = await _dbContext.OrderCustomers.Where(x => x.Id == item.Id).FirstOrDefaultAsync();
            _dbContext.Entry(OrderCustomer).CurrentValues.SetValues(item);
            return await _dbContext.SaveChangesAsync();

        }
    }
}
