﻿using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Loan
{
    public class LoanCollectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
