using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM12.Data.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Classname { get; set; }
        public int Year { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
