using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BOOKSAPI.Models;

namespace BOOKSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicshesController : ControllerBase
    {
        private readonly BookDBContext _context;

        public PublicshesController(BookDBContext context)
        {
            _context = context;
        }

        // GET: api/Publicshes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Publicsh>>> GetPublicsh()
        {
            return await _context.Publicsh.ToListAsync();
        }

        // GET: api/Publicshes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Publicsh>> GetPublicsh(int id)
        {
            var publicsh = await _context.Publicsh.FindAsync(id);

            if (publicsh == null)
            {
                return NotFound();
            }

            return publicsh;
        }

        // PUT: api/Publicshes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPublicsh(int id, Publicsh publicsh)
        {
            if (id != publicsh.PublicsId)
            {
                return BadRequest();
            }

            _context.Entry(publicsh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublicshExists(id))
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

        // POST: api/Publicshes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Publicsh>> PostPublicsh(Publicsh publicsh)
        {
            _context.Publicsh.Add(publicsh);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PublicshExists(publicsh.PublicsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPublicsh", new { id = publicsh.PublicsId }, publicsh);
        }

        // DELETE: api/Publicshes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Publicsh>> DeletePublicsh(int id)
        {
            var publicsh = await _context.Publicsh.FindAsync(id);
            if (publicsh == null)
            {
                return NotFound();
            }

            _context.Publicsh.Remove(publicsh);
            await _context.SaveChangesAsync();

            return publicsh;
        }

        private bool PublicshExists(int id)
        {
            return _context.Publicsh.Any(e => e.PublicsId == id);
        }
    }
}
