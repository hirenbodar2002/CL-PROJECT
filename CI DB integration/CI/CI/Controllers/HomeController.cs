using CI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace CI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly UserDbContext _userDbContext;

        public HomeController(ILogger<HomeController> logger, UserDbContext userDbContext)
        {
            _logger = logger;
            _userDbContext = userDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user )
        {
            var User = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
               Password = user.Password,

            };
            _userDbContext.Users.Add( User );
            _userDbContext.SaveChanges();
            return View("Login");
        }

        
        [HttpGet]
        
        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var starus = _userDbContext.Users.Where(m => m.Email == user.Email && m.Password == user.Password).Count();
            if (starus > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Login");
            }  
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(User user)
        {
            var starus = _userDbContext.Users.Where(m => m.Email == user.Email).Count();
            if (starus > 0)
            {
                return RedirectToAction("index ");
            }
            else
            {
                return RedirectToAction("ForgotPassword");
            }
            
        }

        public IActionResult ResetPassword()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}