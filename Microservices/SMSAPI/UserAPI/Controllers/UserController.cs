using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Repositories;
using UserAPI.Models;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost("Register")]
        public IActionResult Create([FromBody] User user)
        {
            _userRepository.Register(user);
            return Ok(user);
        }
        [HttpPut("EditUser")]
        public IActionResult Update([FromBody] User user)
        {
            _userRepository.EditUser(user);
            return Ok(user);
        }
        [HttpPost("Validate")]
        public IActionResult Validate([FromBody] Login login)
        {
            User user=_userRepository.Validate(login.Username,login.Password);
            if(user != null)
            {
                return Ok(user);
            }
            else
                return BadRequest("Invalid Credentials");
        }
    }
}
