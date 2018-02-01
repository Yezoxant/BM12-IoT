using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BM12.Models
{
    public class UserActivity
    {
        [Key]
        public int UserActivityID { get; set; }
        public int Stars { get; set; }
        public string Comment { get; set; }
        [Required]
        public bool Presence { get; set; }
        public DateTime PresenceDatetime { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("Activity")]
        public int ActivityID { get; set; }
        [ForeignKey("PictureData")]
        public int PictureDataID { get; set; }

        //conventions
        public virtual User User { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual PictureData PictureData { get; set; }
    }
}
