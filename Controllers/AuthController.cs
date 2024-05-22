using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.Data;
using TaskManagerAPI.Data;

namespace TaskManagerAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest loginRequest)
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == loginRequest.Email && u.Password == loginRequest.Password);

            if (user == null)
            {
                return Unauthorized();
            }

            return Ok(user);        }
    }
}
