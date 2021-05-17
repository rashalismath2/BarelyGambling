using AutoMapper;
using BarelyGambling.API.Dto;
using BarelyGambling.Core.Entity;
using BarelyGambling.Core.Exceptions;
using BarelyGambling.Core.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BarelyGambling.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        private readonly IFileUploadService _fileUploadService;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _webEnv;
        private readonly IMapper _mapper;

        public AuthenticationController(
            UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IFileUploadService fileUploadService,
            IConfiguration configuration,
            IWebHostEnvironment webEnv,
            IMapper mapper)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this._fileUploadService = fileUploadService;
            _configuration = configuration;
            this._webEnv = webEnv;
            this._mapper = mapper;
        }

        [HttpPost("register"), DisableRequestSizeLimit]
        public async Task<IActionResult> Register([FromForm] RegisterUserDto model)
        {
            var userExists = await userManager.FindByEmailAsync(model.Email);
            if (userExists != null)
                return Conflict("User already exist with the current email address");


            string filePathToSave = $"{_webEnv.WebRootPath}/profile-images/";
            string savedPath = "";
            if (model.profilePicture != null)
            {
                try
                {
                    savedPath = await _fileUploadService.UploadSingleFile(model.profilePicture, filePathToSave);
                }
                catch (FileSizeExceededException e)
                {
                    ModelState.AddModelError("FileSizeExceededException", e.Message);
                    return BadRequest(ModelState);
                }
                catch (FileExtensionNotFoundException e)
                {
                    ModelState.AddModelError("FileExtensionNotFoundException", e.Message);
                    return BadRequest(ModelState);
                }
                catch (FileSavingToTheLocalStorageException e)
                {
                    ModelState.AddModelError("FileSavingToTheLocalStorageException", e.Message);
                    return BadRequest(ModelState);
                }
            }

            var user = _mapper.Map<AppUser>(model);

            if (!string.IsNullOrEmpty(savedPath))
            {
                user.CoverUrl = "http://localhost:5000/profile-images/" + savedPath;
            }
            else
            {
                user.CoverUrl = "https://via.placeholder.com/150";
            }

            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }


            return CreatedAtRoute("GetUserById", new { Id = user.Id }, _mapper.Map<UserDto>(user)); ;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginUserDto model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo,
                    user = _mapper.Map<UserDto>(user)
                });
            }
            ModelState.AddModelError("Auth Failed","Authentication was failed!");
            return Unauthorized(ModelState);
        }

    }
}
