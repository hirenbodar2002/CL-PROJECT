using Microsoft.AspNetCore.Mvc;
using Registr.Models;
using System.Diagnostics;

namespace Registr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly RegistrationDbContext _registrationDbContext;
        

        public HomeController(ILogger<HomeController> logger, RegistrationDbContext registrationDbContext)
        {
            _logger = logger;
            _registrationDbContext = registrationDbContext; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Registration(Registeration registeration)
        {
            var Registeration = new Registeration()
            {
                FirstName = registeration.FirstName,
                LastName = registeration.LastName,
                Phone = registeration.Phone,
                Email = registeration.Email,
                Password = registeration.Password,
             
            };
           

                _registrationDbContext.Registerations.Add(Registeration);
                _registrationDbContext.SaveChangesAsync();

           


            
           
            

            return View ('');
           
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}