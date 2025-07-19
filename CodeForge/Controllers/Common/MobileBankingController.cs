using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Common
{
    public class MobileBankingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
