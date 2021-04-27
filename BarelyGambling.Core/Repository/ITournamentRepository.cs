using BarelyGambling.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BarelyGambling.Core.Repository
{
    public interface ITournamentRepository
    {
        Task<List<Tournament>> Retrieve();
        Task<Tournament> GetById(Guid tournamentId);
    }
}
