using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok("test");
        }
    }
}
