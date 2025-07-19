using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.MemberManagement
{
    public class UnregistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
