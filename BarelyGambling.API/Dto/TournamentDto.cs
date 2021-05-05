using BarelyGambling.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarelyGambling.API.Dto
{
    public class TournamentDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        public DateTime StartingDate { get; set; }
        [Required]
        public float TournamentPrize { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool HasEnded { get; set; }
        public bool HasStarted { get; set; }
        public UserDto User { get; set; }
        [Required, MinLength(2)]
       
        public List<TeamDto> Teams { get; set; }
    }
}
