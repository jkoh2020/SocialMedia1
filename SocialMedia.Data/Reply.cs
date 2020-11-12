﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
   public class Reply
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        [Required]
        public Guid Author { get; set; }
    }
}
