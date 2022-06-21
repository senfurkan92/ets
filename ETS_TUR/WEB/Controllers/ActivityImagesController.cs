using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    public class ActivityImagesController : ApiController
    {
        public IActionResult Index()
        {
            return Ok("ActivityImages");
        }
    }
}
