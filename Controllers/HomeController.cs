using Microsoft.AspNetCore.Mvc;

namespace Tripzy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
