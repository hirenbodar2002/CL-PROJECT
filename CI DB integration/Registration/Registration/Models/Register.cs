using System;
using System.Collections.Generic;

namespace Registration.Models
{
    public partial class Register
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfrimPassword { get; set; }
    }
}
