using System;
using System.Collections.Generic;
using System.Text;

namespace BM12.Models
{
    public class PictureData
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Attention { get; set; }
        public string Emotion { get; set; }

        //conventions
        public virtual User User { get; set; }
    }
}
