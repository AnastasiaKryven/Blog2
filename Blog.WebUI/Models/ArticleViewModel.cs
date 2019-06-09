using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.WebUI.Models
{
    public class ArticleViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
        public PadingInfo PadingInfo { get; set; }
    }
}