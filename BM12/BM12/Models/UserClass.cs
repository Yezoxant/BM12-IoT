using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BM12.Models
{
    public class UserClass
    {
        public int UserClassID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("Class")]
        public int ClassID { get; set; }

        //conventions
        public User User { get; set; }
        public Class Class { get; set; }
    }
}
