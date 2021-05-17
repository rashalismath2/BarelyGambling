using BarelyGambling.Core.Entity;
using BarelyGambling.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<AppUser>> GetAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<AppUser> GetUserByEmail(string email)
        {
            return await _dbContext.Users.Where(user=>user.Email==email).FirstOrDefaultAsync();
        }

        public async Task<AppUser> GetUserById(string id)
        {
            return await _dbContext.Users.FindAsync(id); ;
        }
    }
}
