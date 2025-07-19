using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Loan
{
    public class LoanApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
