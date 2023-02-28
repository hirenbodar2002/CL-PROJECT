using CI_PROJECT.Models;
using Microsoft.AspNetCore.Mvc;

namespace CI_PROJECT.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(RegistrationModel model)
        {
               
        }

        public IActionResult Forgotpassword()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegistrationModel model)
        {
            return View();  
        }
       

        public IActionResult newpassword()
        {
            return View();
        }
    }
}
