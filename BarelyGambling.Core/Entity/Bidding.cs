using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BarelyGambling.Core.Entity
{
    public class Bidding
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public Team Team { get; set; }
        [Required]
        public AppUser User { get; set; }

    }
}
