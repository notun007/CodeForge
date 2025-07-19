using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Loan
{
    public class ApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
