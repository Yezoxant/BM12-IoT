using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM12.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string IdentityId { get; set; }
        public bool Agreement { get; set; }



        //Conventions
        public virtual ICollection<UserClass> UserClass { get; set; }
        public virtual ICollection<UserActivity> UserActivity { get; set; }
        public AppUser Identity { get; set; }
    }
}
