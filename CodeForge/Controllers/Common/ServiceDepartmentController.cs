using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Common
{
    public class ServiceDepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
