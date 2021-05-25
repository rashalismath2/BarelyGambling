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
        [Required]
        public List<Team> Teams { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public  AppUser User { get; set; }
        public bool HasEnded { get; set; }
        public bool HasStarted { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Like> Likes { get; set; }

        public Tournament()
        {
            this.Comments = new List<Comment>();
            this.Likes = new List<Like>();
            this.Teams = new List<Team>();
        }
    }
}
