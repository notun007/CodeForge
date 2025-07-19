using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Common
{
    public class PaymentMethodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
