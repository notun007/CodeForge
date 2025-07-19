using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Common
{
    public class ReligionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
