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
    public class AuthersController : ControllerBase
    {
        private readonly BookDBContext _context;



        public AuthersController(BookDBContext context)
        {
            _context = context;
        }

        // GET: api/Authers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Auther>>> GetAuther()
        {
            return await _context.Auther.ToListAsync();
        }

        // GET: api/Authers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Auther>> GetAuther(int id)
        {
            var auther = await _context.Auther.FindAsync(id);

            if (auther == null)
            {
                return NotFound();
            }

            return auther;
        }

        [HttpGet("GetName/{name}")]
        public async Task<ActionResult<List<Auther>>> GetName(string name)
        {
            var authers = await _context.Auther.Where(a => a.AutherName.Contains(name)).ToListAsync();

            if (authers == null)
            {
                return NotFound();
            }

            return authers;
        }


        // PUT: api/Authers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuther(int id, Auther auther)
        {
            if (id != auther.AutherId)
            {
                return BadRequest();
            }

            _context.Entry(auther).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutherExists(id))
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

        // POST: api/Authers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Auther>> PostAuther(Auther auther)
        {
            _context.Auther.Add(auther);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AutherExists(auther.AutherId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAuther", new { id = auther.AutherId }, auther);
        }

        // DELETE: api/Authers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Auther>> DeleteAuther(int id)
        {
            var auther = await _context.Auther.FindAsync(id);
            if (auther == null)
            {
                return NotFound();
            }

            _context.Auther.Remove(auther);
            await _context.SaveChangesAsync();

            return auther;
        }

        private bool AutherExists(int id)
        {
            return _context.Auther.Any(e => e.AutherId == id);
        }
    }
}
