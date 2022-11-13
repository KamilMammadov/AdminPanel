using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
        [Area("apps")]
    public class GeneralController : Controller
    {
        public IActionResult Allotments()
        {
            return View();
        }
        public IActionResult Expenses()
        {
            return View();
        }
        public IActionResult Departments()
        {
            return View();
        }
        public IActionResult Insurance()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }

        public IActionResult Leaves()
        {
            return View();
        }

        public IActionResult Holidays()
        {
            return View();
        }

        public IActionResult Attendance()
        {
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }

    }
}
