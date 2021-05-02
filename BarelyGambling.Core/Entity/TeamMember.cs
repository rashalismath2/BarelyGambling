using BarelyGambling.Core.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BarelyGambling.Core.Entity
{
    public class TeamMember
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public AppUser User { get; set; }
        [Required]
        public Team Team { get; set; }
        [Required]
        public PlayerType PlayerType { get; set; }
    }
}
