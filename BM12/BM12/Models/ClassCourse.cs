using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BM12.Models
{
    public class ClassCourse
    {
        public int ClassCourseID { get; set; }
        [ForeignKey("Class")]
        public int ClassID { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }

        //conventions
        public Class Class { get; set; }
        public Course Course { get; set; }
    }
}
