﻿using SocialMedia.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SocialMedia.Models
{
    // Properties will show up in the view   
    public class GetPosts
    {
      public int Id { get; set; }
      public string Title { get; set; }
      public string Text { get; set; }
      public Guid Author { get; set; }

    }
}
