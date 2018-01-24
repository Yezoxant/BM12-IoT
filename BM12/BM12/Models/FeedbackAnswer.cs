using System;
using System.Collections.Generic;
using System.Text;

namespace BM12.Models
{
    public class FeedbackAnswer
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public string Note { get; set; }

        //conventions
        public virtual FeedbackQuestion FeedbackQuestion { get; set; }
        public virtual User user { get; set; }
    }
}
