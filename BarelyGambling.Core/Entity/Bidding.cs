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
        [ForeignKey("TeamId")]
        [Required]
        public Guid TeamId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        [Required]
        public Guid UserId { get; set; }

    }
}
