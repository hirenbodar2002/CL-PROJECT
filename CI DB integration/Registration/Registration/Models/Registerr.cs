using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public partial class Registerr
    {
        public string FirstName { get; set; } = null!;
        [Required(ErrorMessage = "this is required")]
        public string? LastName { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public string? ConfrimPassword { get; set; }
    }
}
