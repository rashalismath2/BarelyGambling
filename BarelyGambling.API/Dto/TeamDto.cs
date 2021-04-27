using BarelyGambling.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarelyGambling.API.Dto
{
    public class TeamDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Total { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
        public List<Bidding> Biddings { get; set; }
        public float BiddingRestrictedTos { get; set; }
        public bool Won { get; set; }
    }
}
