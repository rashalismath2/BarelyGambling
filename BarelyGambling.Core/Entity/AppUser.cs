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
        public List<Tournament> Tournaments { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Like> Likes { get; set; }

        public AppUser()
        {
            Tournaments = new List<Tournament>();
            Likes = new List<Like>();
            Comments = new List<Comment>();
        }
    }
}
