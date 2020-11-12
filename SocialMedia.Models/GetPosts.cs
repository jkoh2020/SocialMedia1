using SocialMedia.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SocialMedia.Models
{
    
    public class GetPosts
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        [HttpGet]
        public async Task<IHttpActionResult> GetAllPost()
        {
            List<Post> posts = await _context.Posts.ToListAsync();
            return Ok(posts);
        }
    }
}
