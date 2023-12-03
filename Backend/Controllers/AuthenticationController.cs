using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;
using WebApi.ViewModels;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _service;

    public AuthenticationController(IAuthenticationService service)
    {
        _service = service;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest model)
    {
        var user = await _service.Login(model);

        if (user != null)
        {
            return Ok(user);
        }

        return NotFound("User not found");
    }
}