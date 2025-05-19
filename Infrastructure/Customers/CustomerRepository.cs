using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models.Customers;
using Core.Repository.Customers;


namespace Infrastructure
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly AdvertiserContextL _dbContext;

        public CustomerRepository(AdvertiserContextL dbContext)
        {
            _dbContext = dbContext;

        }
        public CustomerRepository() { }

        public Task Create(Customer item)
        {
            _dbContext.cus
            return _dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
        }

        public Task<List<Customer>> GetAllAsync()
        {
        }

        public Task<Customer> GetByIdAsync(int id)
        {
        }

        public Task Update(Customer item)
        {
        }
    }

}
