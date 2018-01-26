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
    [Route("api/FeedbackQuestions")]
    public class FeedbackQuestionsController : Controller
    {
        private readonly IotContext _context;

        public FeedbackQuestionsController(IotContext context)
        {
            _context = context;
        }

        // GET: api/FeedbackQuestions
        [HttpGet]
        public IEnumerable<FeedbackQuestion> GetFeedbackQuestions()
        {
            return _context.FeedbackQuestions;
        }

        // GET: api/FeedbackQuestions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeedbackQuestion([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var feedbackQuestion = await _context.FeedbackQuestions.SingleOrDefaultAsync(m => m.Id == id);

            if (feedbackQuestion == null)
            {
                return NotFound();
            }

            return Ok(feedbackQuestion);
        }

        // PUT: api/FeedbackQuestions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeedbackQuestion([FromRoute] int id, [FromBody] FeedbackQuestion feedbackQuestion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != feedbackQuestion.Id)
            {
                return BadRequest();
            }

            _context.Entry(feedbackQuestion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeedbackQuestionExists(id))
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

        // POST: api/FeedbackQuestions
        [HttpPost]
        public async Task<IActionResult> PostFeedbackQuestion([FromBody] FeedbackQuestion feedbackQuestion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.FeedbackQuestions.Add(feedbackQuestion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFeedbackQuestion", new { id = feedbackQuestion.Id }, feedbackQuestion);
        }

        // DELETE: api/FeedbackQuestions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeedbackQuestion([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var feedbackQuestion = await _context.FeedbackQuestions.SingleOrDefaultAsync(m => m.Id == id);
            if (feedbackQuestion == null)
            {
                return NotFound();
            }

            _context.FeedbackQuestions.Remove(feedbackQuestion);
            await _context.SaveChangesAsync();

            return Ok(feedbackQuestion);
        }

        private bool FeedbackQuestionExists(int id)
        {
            return _context.FeedbackQuestions.Any(e => e.Id == id);
        }
    }
}