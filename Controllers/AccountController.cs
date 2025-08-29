using Microsoft.AspNetCore.Mvc;
namespace Tripzy.Controllers;
[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }


    [HttpGet("login",Name = "login")]
    public string Login()
    {
        return "Login";
    }


    [HttpGet("register",Name = "register")]
    public string Register()
    {
        return "registered";
    }

 
}
