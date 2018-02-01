using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM12.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Veld kan maximaal 10 tekens bevatten")]
        public string Classname { get; set; }
        [Required]
        [MaxLength(1, ErrorMessage = "Veld kan maximaal 1 cijfer bevatten")]
        public int Year { get; set; }
        public virtual ICollection<UserClass> UserClass { get; set; }
    }
}
