using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Expenditure
{
    public class ExpenseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
