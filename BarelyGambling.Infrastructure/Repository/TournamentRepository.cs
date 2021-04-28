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
    public class TournamentRepository : ITournamentRepository
    {
        private readonly AppDbContext _dbContext;

        public TournamentRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<Tournament> GetById(Guid tournamentId)
        {
            return await _dbContext.Tournament
                .Include(tournament => tournament.User)
                .Include(tournament => tournament.Teams)
                .ThenInclude(team => team.TeamMembers)  
                .ThenInclude(member => member.User)
                .Include(tournament => tournament.Teams)
                .ThenInclude(team => team.Biddings)
                .Where(tournament => tournament.Id == tournamentId).FirstOrDefaultAsync();
        }

        public async Task<List<Tournament>> Retrieve()
        {
            return await _dbContext.Tournament
                .Include(tournament => tournament.User)
                .Include(tournament => tournament.Teams)
                .ToListAsync();
        }
    }
}
