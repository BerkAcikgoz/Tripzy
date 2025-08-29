using Microsoft.AspNetCore.Mvc;
using Tripzy.Core.Dtos;
using Tripzy.Core.Services;

namespace Tripzy.Controllers;


[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService authService;

    public AuthController(IAuthService authService)
    {
       this.authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserDto request)
    {
        var user = await authService.Register(request.UserName, request.Password);
        if (user == null) return BadRequest("User already exists");

        return Ok(user);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserDto request)
    {
        var token = await authService.Login(request.UserName, request.Password);
        if (token == null) return Unauthorized("Invalid credentials");

        return Ok(new { token });
    }


}
