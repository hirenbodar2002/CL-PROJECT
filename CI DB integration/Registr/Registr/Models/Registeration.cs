using System;
using System.Collections.Generic;

namespace Registr.Models
{
    public partial class Registeration
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;/*
        public object? Registration { get; internal set; }*/
    }
}
