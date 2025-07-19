using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Welfare
{
    public class DisbursementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
