using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Loan
{
    public class DisbursementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
