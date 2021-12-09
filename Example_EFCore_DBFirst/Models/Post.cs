using System;
using System.Collections.Generic;

#nullable disable

namespace Console_EFCore_DBFirst.Models
{
    public partial class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
