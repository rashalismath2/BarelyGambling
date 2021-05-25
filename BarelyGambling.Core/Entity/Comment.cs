using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BarelyGambling.Core.Entity
{
    public class Comment
    {
        public Guid Id { get; set; }
        [Required,ForeignKey("TournamentId")]
        public Guid TournamentId { get; set; }
        [Required, ForeignKey("UserId")]
        public string UserId { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
