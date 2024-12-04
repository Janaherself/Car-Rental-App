using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Customer")]
        public IActionResult CustomerIndex()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AdminIndex()
        {
            return View();
        }
    }
}
