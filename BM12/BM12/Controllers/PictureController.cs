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
    [Route("api/Picture")]
    public class PictureController : Controller
    {
        private readonly IotContext _context;

        public PictureController(IotContext context)
        {
            _context = context;
        }

        // GET: api/Picture
        [HttpGet]
        public IEnumerable<PictureData> GetPictureData()
        {
            return _context.PictureData;
        }

        // GET: api/Picture/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPictureData([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pictureData = await _context.PictureData.SingleOrDefaultAsync(m => m.Id == id);

            if (pictureData == null)
            {
                return NotFound();
            }

            return Ok(pictureData);
        }

        // PUT: api/Picture/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPictureData([FromRoute] int id, [FromBody] PictureData pictureData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pictureData.Id)
            {
                return BadRequest();
            }

            _context.Entry(pictureData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PictureDataExists(id))
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

        // POST: api/Picture
        [HttpPost]
        public async Task<IActionResult> PostPictureData([FromBody] PictureData pictureData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PictureData.Add(pictureData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPictureData", new { id = pictureData.Id }, pictureData);
        }

        // DELETE: api/Picture/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePictureData([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pictureData = await _context.PictureData.SingleOrDefaultAsync(m => m.Id == id);
            if (pictureData == null)
            {
                return NotFound();
            }

            _context.PictureData.Remove(pictureData);
            await _context.SaveChangesAsync();

            return Ok(pictureData);
        }

        private bool PictureDataExists(int id)
        {
            return _context.PictureData.Any(e => e.Id == id);
        }
    }
}