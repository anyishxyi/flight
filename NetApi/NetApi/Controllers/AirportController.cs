using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetApi.Models;

namespace NetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly GlobalDataBaseContext _context;

        public AirportController(GlobalDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Airport
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Airport>>> GetAirports()
        {
            return await _context.Airport.ToListAsync();
        }

        // GET: api/Airport/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Airport>> GetAirport(long id)
        {
            var airport = await _context.Airport.FindAsync(id);

            if (airport == null)
            {
                return NotFound();
            }

            return airport;
        }

        // PUT: api/Airport/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAirport(long id, Airport airport)
        {
            if (id != airport.id)
            {
                return BadRequest();
            }

            _context.Entry(airport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AirportExists(id))
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

        // POST: api/Airport
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Airport>> PostAirport(Airport airport)
        {
            _context.Airport.Add(airport);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAirport", new { id = airport.id }, airport);
        }

        // DELETE: api/Airport/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Airport>> DeleteAirport(long id)
        {
            var airport = await _context.Airport.FindAsync(id);
            if (airport == null)
            {
                return NotFound();
            }

            _context.Airport.Remove(airport);
            await _context.SaveChangesAsync();

            return airport;
        }

        private bool AirportExists(long id)
        {
            return _context.Airport.Any(e => e.id == id);
        }
    }
}
