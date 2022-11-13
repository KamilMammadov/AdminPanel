using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    [Area("apps")]
    public class AppointmentsController : Controller
    {
        public IActionResult Shedule()
        {
            return View();
        }
        public IActionResult AllAppointments()
        {
            return View();
        }
    }
}
