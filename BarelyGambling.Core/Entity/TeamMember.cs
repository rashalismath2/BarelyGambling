using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BarelyGambling.Core.Entity
{
    public class TeamMember
    {
        [Key]
        public Guid Id { get; set; }
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
        public Team Team { get; set; }
        [Required]
        public Guid TeamId { get; set; }

    }
}
