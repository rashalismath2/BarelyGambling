using BarelyGambling.Core.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BarelyGambling.API.Dto
{
    public class TeamMemberDto
    {
        public Guid Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public UserDto User { get; set; }
        [Required]
        public string PlayerType { get; set; }
        [Required, ForeignKey("TeamId")]
        public Guid TeamId { get; set; }
    }
}
