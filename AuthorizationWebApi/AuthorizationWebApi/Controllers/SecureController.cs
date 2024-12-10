using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
[Authorize] // This requires JWT token for access
public class SecureController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("This is a secure endpoint");
    }
}
