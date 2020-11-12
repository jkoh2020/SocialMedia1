﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
   public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public Guid Author { get; set; }
        [Required]
        public int RepliesId { get; set; }


        [ForeignKey(nameof(RepliesId))]
        public virtual Reply Reply { get; set; }


    }
}
