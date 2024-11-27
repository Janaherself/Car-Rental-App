using Microsoft.AspNetCore.Mvc;

namespace CarRentalApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return RedirectToPage("/Account/Register", new { area = "Identity" });
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
    }
}
