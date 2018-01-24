using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM12___Entity_Framework
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Agreement { get; set; }
    }
}
