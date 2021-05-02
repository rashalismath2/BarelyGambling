using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BarelyGambling.Core.Entity
{
    public class Tournament
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime StartingDate { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        public float TournamentPrize { get; set; }
        public List<Team> Teams { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public Guid CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public  User User { get; set; }
        public bool HasEnded { get; set; }
        public bool HasStarted { get; set; }

    }
}
