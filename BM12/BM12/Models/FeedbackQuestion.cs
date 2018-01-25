using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BM12.Models
{
    public class FeedbackQuestion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Question { get; set; }

        //conventions
        public virtual ICollection<FeedbackAnswer> FeedbackAnswer { get; set; }
    }
}
