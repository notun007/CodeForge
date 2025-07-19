using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Common
{
    public class ServiceDivisionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
