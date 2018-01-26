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
    [Route("api/FeedbackAnswers")]
    public class FeedbackAnswersController : Controller
    {
        private readonly IotContext _context;

        public FeedbackAnswersController(IotContext context)
        {
            _context = context;
        }

        // GET: api/FeedbackAnswers
        [HttpGet]
        public IEnumerable<FeedbackAnswer> GetFeedbackanswers()
        {
            return _context.Feedbackanswers;
        }

        // GET: api/FeedbackAnswers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeedbackAnswer([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var feedbackAnswer = await _context.Feedbackanswers.SingleOrDefaultAsync(m => m.Id == id);

            if (feedbackAnswer == null)
            {
                return NotFound();
            }

            return Ok(feedbackAnswer);
        }

        // PUT: api/FeedbackAnswers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeedbackAnswer([FromRoute] int id, [FromBody] FeedbackAnswer feedbackAnswer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != feedbackAnswer.Id)
            {
                return BadRequest();
            }

            _context.Entry(feedbackAnswer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeedbackAnswerExists(id))
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

        // POST: api/FeedbackAnswers
        [HttpPost]
        public async Task<IActionResult> PostFeedbackAnswer([FromBody] FeedbackAnswer feedbackAnswer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Feedbackanswers.Add(feedbackAnswer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFeedbackAnswer", new { id = feedbackAnswer.Id }, feedbackAnswer);
        }

        // DELETE: api/FeedbackAnswers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeedbackAnswer([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var feedbackAnswer = await _context.Feedbackanswers.SingleOrDefaultAsync(m => m.Id == id);
            if (feedbackAnswer == null)
            {
                return NotFound();
            }

            _context.Feedbackanswers.Remove(feedbackAnswer);
            await _context.SaveChangesAsync();

            return Ok(feedbackAnswer);
        }

        private bool FeedbackAnswerExists(int id)
        {
            return _context.Feedbackanswers.Any(e => e.Id == id);
        }
    }
}