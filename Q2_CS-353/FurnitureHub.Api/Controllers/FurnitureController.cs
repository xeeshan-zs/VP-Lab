using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FurnitureHub.Api.Data;
using FurnitureHub.Api.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHub.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FurnitureController : ControllerBase
    {
        private readonly FurnitureDbContext _context;

        public FurnitureController(FurnitureDbContext context)
        {
            _context = context;
        }

        // GET: api/furniture
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FurnitureItem>>> GetFurnitureItems()
        {
            return await _context.FurnitureItems.ToListAsync();
        }

        // GET: api/furniture/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FurnitureItem>> GetFurnitureItem(int id)
        {
            var item = await _context.FurnitureItems.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // PUT: api/furniture/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFurnitureItem(int id, FurnitureItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FurnitureItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/furniture
        [HttpPost]
        public async Task<ActionResult<FurnitureItem>> PostFurnitureItem(FurnitureItem item)
        {
            _context.FurnitureItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFurnitureItem), new { id = item.Id }, item);
        }

        // DELETE: api/furniture/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFurnitureItem(int id)
        {
            var item = await _context.FurnitureItems.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.FurnitureItems.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FurnitureItemExists(int id)
        {
            return _context.FurnitureItems.Any(e => e.Id == id);
        }
    }
}
