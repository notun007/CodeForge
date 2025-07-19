using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Loan
{
    public class LoanDisbursementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
