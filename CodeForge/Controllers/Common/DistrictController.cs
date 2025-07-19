using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Common
{
    public class DistrictController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
