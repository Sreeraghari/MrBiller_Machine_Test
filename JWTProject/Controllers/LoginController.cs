using JWTProject.Model;
using Microsoft.AspNetCore.Mvc;

namespace JWTProject.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _loginService;

        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDto request)
        {
            try
            {
                var result = await _loginService.Register(request);
                if (result == "Email already exists")
                    return Conflict(new { error = result });
                return Ok(new { message = result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }        
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto request)
        {
            try
            {
                var token = await _loginService.Login(request);
            if (token == "Invalid email or password")
                return Unauthorized(new { error = token });

                return Ok(new { token });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
