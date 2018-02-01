using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM12.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int Blocknumber { get; set; }

        //conventions
        public ICollection<ClassCourse> ClassCourse { get; set; }
    }
}
