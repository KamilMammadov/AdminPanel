﻿using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    public class AnalyticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
