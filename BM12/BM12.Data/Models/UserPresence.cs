using System;
using System.Collections.Generic;
using System.Text;

namespace BM12.Data.Models
{
    public class UserPresence
    {
        public int ID { get; set; }
        public string CourseActivity { get; set; }
        public string Course { get; set; }
        public string Week { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        //conventions
        public virtual User user { get; set; }
    }
}
