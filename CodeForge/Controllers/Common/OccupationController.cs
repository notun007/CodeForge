using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Common
{
    public class OccupationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
