using Microsoft.AspNetCore.Mvc;

namespace PatientCareSubsystem.UI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
