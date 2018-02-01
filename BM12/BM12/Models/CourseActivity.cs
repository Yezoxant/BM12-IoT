using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM12.Models
{
    public class CourseActivity
    {
        public int CourseCourseActivityId { get; set; }
        public int CourseId { get; set; }
        public int ActivitiyId { get; set; }

        //conventions
        public Course Course { get; set; }
        public Activity Activity { get; set; }
    }
}
