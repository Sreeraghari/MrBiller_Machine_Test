using System.ComponentModel.DataAnnotations;

namespace JWTProject.Model
{
    public class UserRegisterDto
    {
        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(5)]
        public string Password { get; set; }
    }

    public class UserLoginDto
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
