﻿using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    [Area("apps")]

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
