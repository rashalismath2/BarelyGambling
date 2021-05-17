using BarelyGambling.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarelyGambling.API.Dto
{
    public class TeamDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public float Total { get; set; }
        [Required]
        public Guid TournamentId { get; set; }
        [Required, MinLength(1)]
        public List<TeamMemberDto> TeamMembers { get; set; }
        public List<Bidding> Biddings { get; set; }
        public float BiddingRestrictedTo { get; set; }
        public bool Won { get; set; }
    }
}
