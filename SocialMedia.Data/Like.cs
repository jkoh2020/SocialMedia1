using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
   public class Like
    {
        public Post LikedPost { get; set; }
        [Required]
        public Guid Liker { get; set; }
    }
}
