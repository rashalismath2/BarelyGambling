using System;
using System.Collections.Generic;
using System.Text;

namespace BarelyGambling.Core.Entity
{
    public class Like
    {
        public Guid Id { get; set; }
        public Guid TournamentId { get; set; }
        public string UserId { get; set; }
    }
}
