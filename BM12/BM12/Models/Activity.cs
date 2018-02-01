using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BM12.Models
{
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }
        public string ActivityName { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("ClassCourse")]
        public int ClassCourseID { get; set; }
        
        //conventions
        public ICollection<UserActivity> UserActivity { get; set; }
        public ClassCourse ClassCourse { get; set; }

    }
}
