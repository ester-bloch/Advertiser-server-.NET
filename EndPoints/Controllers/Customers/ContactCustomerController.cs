using Core.Models.Customers;
using Core.Services.Customers;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.Controllers.Customers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactCustomerController : Controller
    {

        private readonly IContactCustomerService _injectionService;
        public ContactCustomerController(IContactCustomerService injection)
        {
            _injectionService = injection;
        }

        [HttpGet]
        public async Task<List<ContactCustomer>> GetAll()
        {
            return await _injectionService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ContactCustomer> GetById(int id)
        {
            return await _injectionService.GetByIdAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _injectionService.DeleteAsync(id);
            if (result > 0)
                return NoContent();
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ContactCustomer c)
        {
            var result = await _injectionService.CreateAsync(c);
            if (result > 0)
                return Ok(result);
            return BadRequest();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] ContactCustomer c)
        {
            var result = await _injectionService.UpdateAsync(c);
            if (result > 0)
                return Ok(result);
            return NotFound();
        }
    }
}
