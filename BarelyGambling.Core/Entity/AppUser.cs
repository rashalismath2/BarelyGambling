using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BarelyGambling.Core.Entity
{
    public class AppUser : IdentityUser
    {
 
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string CoverUrl { get; set; }
        List<Tournament> Tournaments { get; set; }

        public AppUser()
        {
            Tournaments = new List<Tournament>();
        }
    }
}
