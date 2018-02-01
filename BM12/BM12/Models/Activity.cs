using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM12.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string ActivityName { get; set; }
        
        //conventions
        public ICollection<UserActivity> UserActivity { get; set; }
    }
}
