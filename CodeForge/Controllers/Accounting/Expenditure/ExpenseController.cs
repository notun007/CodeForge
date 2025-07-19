using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Accounting.Expenditure
{
    public class ExpenseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
