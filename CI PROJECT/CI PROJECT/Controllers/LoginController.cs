using Microsoft.AspNetCore.Mvc;

namespace CI_PROJECT.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Forgotpassword()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult newpassword()
        {
            return View();
        }
    }
}
