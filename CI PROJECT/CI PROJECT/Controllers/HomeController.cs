using CI_PROJECT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CI_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult missiondetailpage()
        {
            return View();
        }

        public IActionResult missionnotfound()
        {
            return View();
        }

        public IActionResult Platfromdetail()
        {
            return View();
        }

        public IActionResult Storys()
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