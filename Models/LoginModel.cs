using System.ComponentModel.DataAnnotations;

namespace DonateBlood.Models
{
    public class LoginModel
    {
        [Required,MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; }
        [Required,MaxLength(250)]
        public string Password { get; set; }
    }
}