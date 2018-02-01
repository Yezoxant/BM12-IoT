using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BM12.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public int Blocknumber { get; set; }

        //conventions
        public ICollection<ClassCourse> ClassCourse { get; set; }
    }
}
