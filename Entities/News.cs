using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class News
    {
        public int NewsId { get; set; }
        public string NewsAppRef { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
