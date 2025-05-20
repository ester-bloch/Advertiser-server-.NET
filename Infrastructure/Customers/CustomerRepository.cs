using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models.Customers;
using Core.Repository.Customers;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AdvertiserContext _dbContext;

        public CustomerRepository(AdvertiserContext dbContext)
        {
            _dbContext = dbContext;

        }
        public Task<int> CreateAsync(Customer item)
        {
            _dbContext.Customers.Add(item);
            return _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(int id)
        {
            var customer = await _dbContext.Customers.FindAsync(id);
            if (customer != null)
            {
                _dbContext.Customers.Remove(customer);
              return  await _dbContext.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<List<Customer>> GetAllAsync()
        {
            return await _dbContext.Customers.ToListAsync();
        }
        public async Task<Customer> GetByIdAsync(int id)

        {
            return await _dbContext.Customers.Where(Customer => Customer.Id == id).FirstOrDefaultAsync();

        }
        public async Task<int> UpdateAsync(Customer item)
        {
            var Customer = await _dbContext.Customers.Where(x => x.Id == item.Id).FirstOrDefaultAsync();
            _dbContext.Entry(Customer).CurrentValues.SetValues(item);
            return await _dbContext.SaveChangesAsync();

        }

    }

}
