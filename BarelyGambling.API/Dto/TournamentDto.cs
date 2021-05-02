using BarelyGambling.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarelyGambling.API.Dto
{
    public class TournamentDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime StartingDate { get; set; }
        public float TournamentPrize { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool HasEnded { get; set; }
        public bool HasStarted { get; set; }
        public UserDto User { get; set; }
        public List<TeamDto> Teams { get; set; }
    }
}
