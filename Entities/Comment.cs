using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public News News { get; set; }


    }
}
