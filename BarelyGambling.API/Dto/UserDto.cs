using BarelyGambling.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarelyGambling.API.Dto
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string CoverUrl { get; set; }
        List<Tournament> Tournaments { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
