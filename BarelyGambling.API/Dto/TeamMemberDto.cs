using BarelyGambling.Core.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarelyGambling.API.Dto
{
    public class TeamMemberDto
    {
        public Guid Id { get; set; }
        public UserDto User { get; set; }
        public PlayerType PlayerType { get; set; }
    }
}
