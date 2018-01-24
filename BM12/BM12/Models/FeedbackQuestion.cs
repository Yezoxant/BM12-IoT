using System;
using System.Collections.Generic;
using System.Text;

namespace BM12.Models
{
    public class FeedbackQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }

        //conventions
        public virtual ICollection<FeedbackAnswer> FeedbackAnswer { get; set; }
    }
}
