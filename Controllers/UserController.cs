using Microsoft.AspNetCore.Mvc;
using Tripzy.Core.Dtos;

namespace Tripzy.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "userlist")]
    public IEnumerable<UserDto> UserList()
    {
        return Enumerable.Range(1, 5).Select(index => new UserDto
        {
            UserName = "berk" ,
        })
        .ToArray();
    }

 
}
