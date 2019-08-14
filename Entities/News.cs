using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class News
    {
        public int NewsId { get; set; }
        public int CommentId { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
