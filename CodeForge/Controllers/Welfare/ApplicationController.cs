using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Welfare
{
    public class ApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
