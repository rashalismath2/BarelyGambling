using AutoMapper;
using BarelyGambling.API.Dto;
using BarelyGambling.Core.Entity;
using BarelyGambling.Core.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarelyGambling.API.Controllers
{
    [ApiController]
    [Route("api/tournaments")]
    public class TournamentController : ControllerBase
    {
        private readonly ITournamentRepository _tournamentRepository;

        public TournamentController(ITournamentRepository tournamentRepository, IMapper mapper)
        {
            this._tournamentRepository = tournamentRepository;
            _mapper = mapper;
        }

        public IMapper _mapper { get; }

        [HttpGet]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<TournamentDto>>> GetAll()
        {
            List<Tournament> tournaments = await _tournamentRepository.Retrieve();
            IEnumerable<TournamentDto> tournamentsDtos = _mapper.Map<IEnumerable<TournamentDto>>(tournaments);

            return Ok(tournamentsDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TournamentDto>> GetById(Guid id) {
            Tournament tournament = await _tournamentRepository.GetById(id);

            if (tournament==null) {
                return NotFound();
            }

            TournamentDto tournamentsDtos = _mapper.Map<TournamentDto>(tournament);
            return Ok(tournamentsDtos);
        }
    }
}
