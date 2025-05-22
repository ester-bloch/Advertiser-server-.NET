using Core.Models.Customers;
using Core.Models.Orders;
using Core.Services.Customers;
using Core.Services.Orders;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.Controllers.Orders
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {

        private readonly IOrderService _injectionService;
        public OrderController(IOrderService injection)
        {
            _injectionService = injection;
        }

        [HttpGet]
        public async Task<List<Order>> GetAll()
        {
            return await _injectionService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Order> GetById(int id)
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
        public async Task<IActionResult> Create([FromBody] Order c)
        {
            var result = await _injectionService.CreateAsync(c);
            if (result > 0)
                return Ok(result);
            return BadRequest();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] Order c)
        {
            var result = await _injectionService.UpdateAsync(c);
            if (result > 0)
                return Ok(result);
            return NotFound();
        }
    }
}
