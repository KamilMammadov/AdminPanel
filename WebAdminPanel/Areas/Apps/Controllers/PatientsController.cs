using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    [Area("apps")]
    public class PatientsController : Controller
    {
        public IActionResult AllPatients()
        {
            return View();
        }

        public IActionResult AddPatient()
        {
            return View();
        }
        public IActionResult PatientEdit()
        {
            return View();
        }
        public IActionResult PatientProfile()
        {
            return View();
        }
    }
}
