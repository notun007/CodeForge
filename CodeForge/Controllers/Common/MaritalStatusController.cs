using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Common
{
    public class MaritalStatusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
