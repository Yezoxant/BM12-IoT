using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BM12;
using BM12.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Net.Http;

namespace BM12___Webapplication.Controllers
{
    [Produces("application/json")]
    [Route("api/Picture")]
    public class PictureController : Controller
    {
        private readonly IotContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public PictureController(IotContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        

        // POST: api/Picture
        [HttpPost]
        public async Task<IActionResult> PostPictureData([FromBody] PictureDto pictureData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            //var id = _userManager.GetUserId(User);

            await _context.PictureData.AddAsync(new PictureData { Attention = pictureData.Attention, DateTime = DateTime.Now, Emotion = pictureData.Emotion, UserId = 3});
            await _context.SaveChangesAsync();

            return Ok(pictureData);
        }


        public class PictureDto
        {
            public string Emotion { get; set; }
      
            public string Attention { get; set; }
        }
    }
}