using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BarelyGambling.Core.Entity
{
    public class Bidding
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public float Amount { get; set; }
        public Team Team { get; set; }
        [Required]
        public int TeamId { get; set; }
        public User User { get; set; }
        [Required]
        public Guid UserId { get; set; }

    }
}
