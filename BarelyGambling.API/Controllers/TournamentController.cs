using AutoMapper;
using BarelyGambling.API.Dto;
using BarelyGambling.Core.Entity;
using BarelyGambling.Core.Models;
using BarelyGambling.Core.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BarelyGambling.API.Controllers
{

    [ApiController]
    [Route("api/tournaments")]

    public class TournamentController : ControllerBase
    {
        private readonly ITournamentRepository _tournamentRepository;
        private readonly IUserRepository _userRepository;
        public IMapper _mapper { get; }

        public TournamentController(ITournamentRepository tournamentRepository, IUserRepository userRepository, IMapper mapper)
        {
            this._tournamentRepository = tournamentRepository;
            this._userRepository = userRepository;
            _mapper = mapper;
        }



        [HttpGet(Name ="GetAllTournaments")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<TournamentDto>>> GetAll([FromQuery] TournamentResourceParameters resourceParameters)
        {
            var tournaments = await _tournamentRepository.Retrieve(resourceParameters);
            IEnumerable<TournamentDto> tournamentsDtos = _mapper.Map<IEnumerable<TournamentDto>>(tournaments);

            var nextPageLink = tournaments.HasNext ? CreateTournamentResouceUri(resourceParameters,ResourceUriType.NextPage) : null;
            var previousPageLink = tournaments.HasPrevious ? CreateTournamentResouceUri(resourceParameters, ResourceUriType.PreviousPage) : null;

            var metaData = new
            {
                TotalCount = tournaments.Count,
                PageSize = tournaments.PageSize,
                CurrentPage = tournaments.CurrentPage,
                TotalPages = tournaments.TotalPages,
                NextPage = nextPageLink,
                PreviousPage = previousPageLink
            };

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metaData));

            return Ok(tournamentsDtos);
        }

        [HttpGet("{id}", Name = "GetTournamentById")]
        public async Task<ActionResult<TournamentDto>> GetById(Guid id)
        {
            Tournament tournament = await _tournamentRepository.GetById(id);

            if (tournament == null)
            {
                return NotFound();
            }

            TournamentDto tournamentsDtos = _mapper.Map<TournamentDto>(tournament);
            return Ok(tournamentsDtos);
        }

        [Authorize]
        [HttpPost(Name = "CreateTournament")]
        public async Task<IActionResult> CreateTournament([FromBody] TournamentDto tournamentDto)
        {
            Tournament tournament = _mapper.Map<Tournament>(tournamentDto);

            try
            {
                AppUser user = await _userRepository.GetUserByEmail(HttpContext.User.Identity.Name.ToString());
                tournament.CreatedBy = user.Id;
            }
            catch (SqlException ex)
            {
                return StatusCode(500);
            }


            try
            {
                await _tournamentRepository.CreateTournament(tournament);
                await _tournamentRepository.Commit();
            }
            catch (SqlException ex)
            {
                return StatusCode(500);
            }

            var tournamentToReturn = _mapper.Map<TournamentDto>(tournament);

            return CreatedAtRoute("GetTournamentById", new { id = tournament.Id }, tournamentToReturn);
        }

        [Authorize]
        [HttpPut("{id}", Name = "UpdateTournament")]
        public async Task<IActionResult> UpdateTournament([FromBody] TournamentDto tournamentDto)
        {

            Tournament tournament = _mapper.Map<Tournament>(tournamentDto);
            AppUser user = null;
            Tournament oldTournament = null;
            try
            {
                user = await _userRepository.GetUserByEmail(HttpContext.User.Identity.Name.ToString());
                oldTournament = await _tournamentRepository.GetById(tournament.Id);
            }
            catch (SqlException)
            {
                return StatusCode(500);
            }

            var signedInUserCreatedTheTournament = (oldTournament.CreatedBy == user.Id);
            if (!signedInUserCreatedTheTournament) return StatusCode(403, new JsonResult(new { error = "You are forbidden to update" }));

            try
            {
                tournament.CreatedBy = oldTournament.CreatedBy;
                tournament = await _tournamentRepository.UpdateTournament(tournament);
            }
            catch (SqlException ex)
            {
                return StatusCode(500);
            }

            var tournamentToReturn = _mapper.Map<TournamentDto>(tournament);

            return CreatedAtRoute("GetTournamentById", new { id = tournament.Id }, tournamentToReturn);
        }

        private string CreateTournamentResouceUri(TournamentResourceParameters parameters,ResourceUriType uriType) {

            switch (uriType)
            {
                case ResourceUriType.NextPage:
                    return Url.Link("GetAllTournaments",new { 
                       pageNumer=parameters.PageNumber+1,
                       pageSize=parameters.PageSize
                    });
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetAllTournaments", new
                    {
                        pageNumer = parameters.PageNumber- 1,
                        pageSize = parameters.PageSize
                    });
                default:
                    return Url.Link("GetAllTournaments", new
                    {
                        pageNumer = parameters.PageNumber,
                        pageSize = parameters.PageSize
                    });
            }
        }
    }
}
