using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BarelyGambling.Core.Entity
{
    public class Team
    {
        public Team()
        {
            TeamMembers = new List<TeamMember>();
            Biddings = new List<Bidding>();
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public float Total { get; set; }
        [Required]
        public Guid TournamentId { get; set; }
        [ForeignKey("TournamentId")]
        public Tournament Tournament { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
        public List<Bidding> Biddings { get; set; }

        public bool Won { get; set; }

    }
}
