using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
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
