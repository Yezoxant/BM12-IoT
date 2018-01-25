using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BM12.Models
{
    public class UserPresence
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Veld kan maximaal 50 tekens bevatten")]
        public string CourseActivity { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Veld kan maximaal 50 tekens bevatten")]
        public string Course { get; set; }
        [Required]
        [MaxLength(2,ErrorMessage ="Maximale lengte is 2 cijfers")]
        public int Week { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        //conventions
        public virtual User user { get; set; }
    }
}
