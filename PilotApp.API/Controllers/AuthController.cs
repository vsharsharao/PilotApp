using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pilotapp.API.Models;
using PilotApp.API.Dtos;
using PilotApp.API.Interfaces;

namespace PilotApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        public readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto user)
        {
            //validate request

            user.Username = user.Username.ToLower();

            if (await _repo.UserExists(user.Username))
                return BadRequest("Username already exists");

            var newUser = new User()
            {
                UserName = user.Username
            };

            var createdUser = _repo.Register(newUser, user.Password);

            return StatusCode(201);
        }
    }
}