using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FilRougeBiblio.Core.Entities;
using FilRougeBiblio.Infrastructure.Data;

namespace FilRougeBiblio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotClefsController : ControllerBase
    {
        private readonly FilRougeBiblioContext _context;

        public MotClefsController(FilRougeBiblioContext context)
        {
            _context = context;
        }

        // GET: api/MotClefs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MotClef>>> GetMotClefs()
        {
          if (_context.MotClefs == null)
          {
              return NotFound();
          }
            return await _context.MotClefs.ToListAsync();
        }

        // GET: api/MotClefs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MotClef>> GetMotClef(int id)
        {
          if (_context.MotClefs == null)
          {
              return NotFound();
          }
            var motClef = await _context.MotClefs.FindAsync(id);

            if (motClef == null)
            {
                return NotFound();
            }

            return motClef;
        }

        // PUT: api/MotClefs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMotClef(int id, MotClef motClef)
        {
            if (id != motClef.Id)
            {
                return BadRequest();
            }

            _context.Entry(motClef).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MotClefExists(id))
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

        // POST: api/MotClefs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MotClef>> PostMotClef(MotClef motClef)
        {
          if (_context.MotClefs == null)
          {
              return Problem("Entity set 'FilRougeBiblioContext.MotClefs'  is null.");
          }
            _context.MotClefs.Add(motClef);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMotClef", new { id = motClef.Id }, motClef);
        }

        // DELETE: api/MotClefs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMotClef(int id)
        {
            if (_context.MotClefs == null)
            {
                return NotFound();
            }
            var motClef = await _context.MotClefs.FindAsync(id);
            if (motClef == null)
            {
                return NotFound();
            }

            _context.MotClefs.Remove(motClef);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MotClefExists(int id)
        {
            return (_context.MotClefs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
