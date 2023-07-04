using Microsoft.AspNetCore.Mvc;

namespace ContatosAppPresentation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult PasswordRecover()
        {
            return View();
        }
    }
}
