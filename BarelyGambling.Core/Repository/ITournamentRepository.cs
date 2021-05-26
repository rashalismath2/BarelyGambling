using BarelyGambling.Core.Entity;
using BarelyGambling.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BarelyGambling.Core.Repository
{
    public interface ITournamentRepository
    {
        Task<PageList<Tournament>> Retrieve(TournamentResourceParameters parameters);
        Task<Tournament> GetById(Guid tournamentId);
        Task<Tournament> CreateTournament(Tournament tournament);
        Task<Tournament> UpdateTournament(Tournament tournament);
        Task<int> Commit();
    }
}
