using AutoMapper;
using BarelyGambling.API.Dto;
using BarelyGambling.Core.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarelyGambling.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            this._userRepository = userRepository;
            this._mapper = mapper;
        }
        [HttpGet("{id}",Name ="GetUserById")]
        public async Task<IActionResult> GetUserById(string id) {

            try
            {
                var user = await _userRepository.GetUserById(id);
                if (user == null)
                {
                    return NotFound();
                }
                return new JsonResult(_mapper.Map<UserDto>(user)); ;
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }
        [HttpGet]
        public async Task<ActionResult> GetAllUsers() {
            try
            {
                var users = await _userRepository.GetAllUsers();
                if (users.Count<1)
                {
                    return NotFound();
                }
                return new JsonResult(_mapper.Map<List<UserDto>>(users)); ;
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
