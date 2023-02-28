namespace CI_PROJECT.Models
{
    public class RegistrationModel
    {
        public string FastName { get; set; }
        public string LastName { get; set; }    
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfrimPassword { get; set; }
    }
}
