using System.ComponentModel.DataAnnotations;

namespace CI_PROJECT.Models
{ 
    public class RegisterModel
    {
        [Key]
        public int Id { get; set; }
        public int Firstname { get; set; }
        public string Lastname { get; set; }
        public long phonenumber { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confrimPassword { get; set; }


    }
}
