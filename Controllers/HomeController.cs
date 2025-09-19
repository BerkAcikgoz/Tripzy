using Microsoft.AspNetCore.Mvc;
using Tripzy.Core.Dtos;

namespace Tripzy.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "categories")]
    public IEnumerable<UserDto> CategoryList()
    {
        return Enumerable.Range(1, 5).Select(index => new UserDto
        {
            UserName = "berk" ,
        })
        .ToArray();
    }

 
}
