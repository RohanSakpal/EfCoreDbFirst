using EfCoreDbFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EfCoreDbFirst.Controllers
{
    [Route("api/[controller]")]
    public class ValueController : ControllerBase
    {
        private readonly minimaldbContext _context;
        public ValueController(minimaldbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployee()
        {
            return Ok(await _context.Employees.ToListAsync());
        }
    }
}
