using Core.Models.Customers;
using Core.Services.Customers;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.Controllers.ManagerEndPoints.Customers
{
    [ApiController]
    [Route("manager/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _injectionService;
        public CustomerController(ICustomerService injection)
        {
            _injectionService = injection;
        }

        [HttpGet]
        public async Task<List<Customer>> GetAll()
        {
            return await _injectionService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Customer> GetById(int id)
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
        public async Task<IActionResult> Create([FromBody] Customer c)
        {
            var result = await _injectionService.CreateAsync(c);
            if (result > 0)
                return Ok(result);
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Customer c)
        {
            var result = await _injectionService.UpdateAsync(c);
            if (result > 0)
                return Ok(result);
            return NotFound();
        }
    }


}