using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BM12.Models
{
    public class Beacon
    {
        [Key]
        public string UID { get; set; }
        public string ClassRoom { get; set; }
        public string Modelnumber { get; set; }
        public string FirmwareVersion { get; set; }
    }
}
