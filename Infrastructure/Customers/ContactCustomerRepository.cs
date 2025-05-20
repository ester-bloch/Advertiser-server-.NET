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
    public class ContactCustomerRepository:IContactCustomerRepository
    {
        private readonly AdvertiserContext _dbContext;

        public ContactCustomerRepository(AdvertiserContext dbContext)
        {
            _dbContext = dbContext;

        }
        public Task<int> CreateAsync(ContactCustomer item)
        {
            _dbContext.ContactCustomers.Add(item);
            return _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(int id)
        {
            var ContactCustomer = await _dbContext.ContactCustomers.FindAsync(id);
            if (ContactCustomer != null)
            {
                _dbContext.ContactCustomers.Remove(ContactCustomer);
                return await _dbContext.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<List<ContactCustomer>> GetAllAsync()
        {
            return await _dbContext.ContactCustomers.ToListAsync();
        }
        public async Task<ContactCustomer> GetByIdAsync(int id)

        {
            return await _dbContext.ContactCustomers.Where(ContactCustomer => ContactCustomer.Id == id).FirstOrDefaultAsync();

        }
        public async Task<int> UpdateAsync(ContactCustomer item)
        {
            var ContactCustomer = await _dbContext.ContactCustomers.Where(x => x.Id == item.Id).FirstOrDefaultAsync();
            _dbContext.Entry(ContactCustomer).CurrentValues.SetValues(item);
            return await _dbContext.SaveChangesAsync();

        }
    }
}
