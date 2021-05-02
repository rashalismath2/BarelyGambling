using BarelyGambling.Core.Entity;
using BarelyGambling.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BarelyGambling.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<AppUser> GetUserById(string id)
        {
            return await _dbContext.Users.FindAsync(id); ;
        }
    }
}
