using Microsoft.AspNetCore.Mvc;

namespace PatientCareSubsystem.UI.Controllers
{
    public class LandingPageController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Doctors()
        {
            return View();
        }
    }
}
