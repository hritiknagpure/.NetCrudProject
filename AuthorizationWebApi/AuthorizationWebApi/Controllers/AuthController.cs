using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly JwtTokenService _jwtTokenService;

    public AuthController(JwtTokenService jwtTokenService)
    {
        _jwtTokenService = jwtTokenService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel login)
    {
        // Normally, validate the user credentials against a database.
        if (login.Username == "test" && login.Password == "password")
        {
            var token = _jwtTokenService.GenerateToken(login.Username);
            return Ok(new { token });
        }

        return Unauthorized();
    }
}

public class LoginModel
{
    public string Username { get; set; }
    public string Password { get; set; }
}
