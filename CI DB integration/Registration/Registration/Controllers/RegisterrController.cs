using Microsoft.AspNetCore.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class RegisterrController : Controller
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public RegisterrController(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }


        public IActionResult Registr()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Registr(Register register)
        {
            var Register = new Register()
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                Password = register.Password,
                Email = register.Email,
                PhoneNumber = register.PhoneNumber,
                ConfrimPassword = register.ConfrimPassword,

            };
            _employeeDbContext.Registers.Add(Register);
            _employeeDbContext.SaveChanges();
            return View();

        }
    }
}
