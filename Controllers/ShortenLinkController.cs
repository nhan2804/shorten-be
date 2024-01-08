using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationX.Data;
using WebApplicationX.Models;

namespace WebApplicationX.Controllers
{
    [ApiController]
    [Route("api/shortens")]
    public class ShortenLinkController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ShortenLinkController> _logger;

        public ShortenLinkController(ILogger<ShortenLinkController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Shorten>>> Get()
        {
            var entities = await _context.Shortens.ToListAsync();
            return Ok(entities);
        }

        [HttpGet("r/{code}")]
        public async Task<ActionResult<Shorten>> GetByCode(string code)
        {
            var entity = await _context.Shortens.FirstOrDefaultAsync(s => s.CodeLink == code);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Shorten>> GetById(int id)
        {
            var entity = await _context.Shortens.FindAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        [HttpPost("")]
        public async Task<ActionResult<Shorten>> Create([FromBody] Shorten shorten)
        {
            _context.Shortens.Add(shorten);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = shorten.Id }, shorten);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Shorten shorten)
        {
            if (id != shorten.Id)
            {
                return BadRequest();
            }

            _context.Entry(shorten).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShortenExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _context.Shortens.FindAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            _context.Shortens.Remove(entity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShortenExists(int id)
        {
            return _context.Shortens.Any(e => e.Id == id);
        }
    }
}
