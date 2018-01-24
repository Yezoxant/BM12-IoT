using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM12.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Agreement { get; set; }

        //Conventions
        public virtual Class Class { get; set; }
        public virtual ICollection<FeedbackAnswer> FeedbackAnswer { get; set; }
        public virtual ICollection<UserPresence> UserPresence { get; set; }
        public virtual ICollection<PictureData> PictureData { get; set; }
    }
}
