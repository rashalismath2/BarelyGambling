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

        public async Task<int> Commit()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Tournament> CreateTournament(Tournament tournament)
        {
            await _dbContext.Tournaments.AddAsync(tournament);
            return tournament;
        }

        public async Task<Tournament> UpdateTournament(Tournament tournament)
        {
             _dbContext.Tournaments.Update(tournament);
            await this.Commit();
            return tournament;
        }

        public async Task<Tournament> GetById(Guid tournamentId)
        {
            return await _dbContext.Tournaments.AsNoTracking()
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
            return await _dbContext.Tournaments
                .Include(tournament => tournament.User)
                .Include(tournament => tournament.Teams)
                .ToListAsync();
        }
    }
}
