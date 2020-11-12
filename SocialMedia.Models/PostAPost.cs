using SocialMedia.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace SocialMedia.Models
{
   public class PostAPost
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }

        // Create
        [HttpPost]
        public async Task<IHttpActionResult> Create(Post post)
        {
            
            if (ModelState.IsValid)
            {
                _context.Posts.Add(post);
                await _context.SaveChangesAsync();
                return Ok;
            }

            return BadRequest(ModelState); // 400
        }

    }

    
}
