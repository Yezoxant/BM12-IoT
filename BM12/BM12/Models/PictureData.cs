using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BM12.Models
{
    public class PictureData
    {
        [Key]
        public int PictureDataID { get; set; }
        public DateTime DateTime { get; set; }
        public string Attention { get; set; }
        public string Emotion { get; set; }

        //conventions
        public virtual ICollection<UserActivity> UserActivity { get; set; }
    }
}
