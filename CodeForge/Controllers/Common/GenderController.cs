using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Common
{
    public class GenderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
