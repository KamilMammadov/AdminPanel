using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult AllStaff()
        {
            return View();
        }
        public IActionResult AddMember()
        {
            return View();
        }
        public IActionResult EditMember()
        {
            return View();
        }
        public IActionResult MemberProfile()
        {
            return View();
        }
        public IActionResult Salary()
        {
            return View();
        }
    }
}
