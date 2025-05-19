using Core.Models.Customers;
using Core.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.Customers
{
    public  interface IOrderCustomerRepository
    {
        Task<List<OrderCustomer>> GetAllAsync();
        Task<OrderCustomer> GetByIdAsync(int id);

        Task DeleteAsync(int id);
        Task Update(OrderCustomer item);
        Task Create(OrderCustomer item);
    }
}
