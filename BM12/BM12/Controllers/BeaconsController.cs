using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BM12;
using BM12.Models;

namespace BM12___Webapplication.Controllers
{
    [Produces("application/json")]
    [Route("api/Beacons")]
    public class BeaconsController : Controller
    {
        private readonly IotContext _context;

        public BeaconsController(IotContext context)
        {
            _context = context;
        }

        // GET: api/Beacons
        [HttpGet]
        public IEnumerable<Beacon> GetBeacons()
        {
            return _context.Beacons;
        }

        // GET: api/Beacons/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBeacon([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var beacon = await _context.Beacons.SingleOrDefaultAsync(m => m.UID == id);

            if (beacon == null)
            {
                return NotFound();
            }

            return Ok(beacon);
        }

        // PUT: api/Beacons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBeacon([FromRoute] string id, [FromBody] Beacon beacon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != beacon.UID)
            {
                return BadRequest();
            }

            _context.Entry(beacon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeaconExists(id))
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

        // POST: api/Beacons
        [HttpPost]
        public async Task<IActionResult> PostBeacon([FromBody] Beacon beacon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Beacons.Add(beacon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBeacon", new { id = beacon.UID }, beacon);
        }

        // DELETE: api/Beacons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBeacon([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var beacon = await _context.Beacons.SingleOrDefaultAsync(m => m.UID == id);
            if (beacon == null)
            {
                return NotFound();
            }

            _context.Beacons.Remove(beacon);
            await _context.SaveChangesAsync();

            return Ok(beacon);
        }

        private bool BeaconExists(string id)
        {
            return _context.Beacons.Any(e => e.UID == id);
        }
    }
}