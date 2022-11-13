using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    [Area("apps")]
    public class DoctorsController : Controller
    {
        public IActionResult AllDoctors()
        {
            return View();
        }
        public IActionResult AddDoctor()
        {
            return View();
        }
        public IActionResult DoctorEdit()
        {
            return View();
        }
        public IActionResult DoctorProfile()
        {
            return View();
        }
    }
}
