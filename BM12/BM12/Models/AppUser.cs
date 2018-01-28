using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BM12.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(50, ErrorMessage = "Veld kan maximaal 50 tekens bevatten")]
        public string Firstname { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Veld kan maximaal 50 tekens bevatten")]
        public string Surname { get; set; }
    }
}
