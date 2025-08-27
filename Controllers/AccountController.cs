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

    [HttpGet("register",Name = "register")]
    public string Register()
    {
        return "registered";
    }

 
}
