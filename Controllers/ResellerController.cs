using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ECommercePlatform.Models;

namespace ECommercePlatform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResellerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ResellerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/reseller
        [HttpGet]
        public async Task<IActionResult> GetResellers()
        {
            var resellers = await _context.Resellers.ToListAsync();
            return Ok(resellers);
        }

        // GET: api/reseller/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReseller(int id)
        {
            var reseller = await _context.Resellers.FindAsync(id);

            if (reseller == null)
            {
                return NotFound();
            }

            return Ok(reseller);
        }

        // POST: api/reseller
        [HttpPost]
        public async Task<IActionResult> CreateReseller([FromBody] Reseller reseller)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Resellers.Add(reseller);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetReseller), new { id = reseller.ResellerId }, reseller);
        }

        // PUT: api/reseller/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReseller(int id, [FromBody] Reseller reseller)
        {
            if (id != reseller.ResellerId)
            {
                return BadRequest();
            }

            _context.Entry(reseller).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/reseller/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReseller(int id)
        {
            var reseller = await _context.Resellers.FindAsync(id);

            if (reseller == null)
            {
                return NotFound();
            }

            _context.Resellers.Remove(reseller);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
