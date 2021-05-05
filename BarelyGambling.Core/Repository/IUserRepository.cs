using BarelyGambling.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BarelyGambling.Core.Repository
{
    public interface IUserRepository
    {
        Task<AppUser> GetUserById(string id);        
        Task<AppUser> GetUserByEmail(string email);
    }
}
