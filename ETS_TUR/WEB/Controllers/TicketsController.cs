using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    public class TicketsController : ApiController
    {
        public IActionResult Index()
        {
            return Ok("ticket");
        }
    }
}
