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
        public float Total { get;private set; }
        [Required]
        public Guid TournamentId { get; set; }
        [Required, MinLength(1)]
        public List<TeamMember> TeamMembers { get; set; }
        public List<Bidding> Biddings { get; set; }
        public float BiddingRestrictedTo { get; set; }
        public bool Won { get; set; }


    }
}
