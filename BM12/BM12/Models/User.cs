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
        [Key]
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public bool Agreement { get; set; }


        //Conventions
        public virtual Class Class { get; set; }
        public virtual ICollection<FeedbackAnswer> FeedbackAnswer { get; set; }
        public virtual ICollection<UserPresence> UserPresence { get; set; }
        public virtual ICollection<PictureData> PictureData { get; set; }
        public AppUser Identity { get; set; }
    }
}
