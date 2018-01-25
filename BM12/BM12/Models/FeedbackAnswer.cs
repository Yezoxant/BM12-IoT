﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BM12.Models
{
    public class FeedbackAnswer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Stars { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Veld kan maximaal 50 tekens bevatten")]
        public string Note { get; set; }

        //conventions
        public virtual FeedbackQuestion FeedbackQuestion { get; set; }
        public virtual User user { get; set; }
    }
}
