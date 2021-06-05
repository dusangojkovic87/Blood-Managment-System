using System.ComponentModel.DataAnnotations;

namespace DonateBlood.Models
{
    public class UserModel
    {  
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [Required,MaxLength(100)]
        public string Surname { get; set; }
        [Required,MaxLength(100)]
        public string Location { get; set; }
        [Required,MaxLength(100)]
        public string Phone { get; set; }
        [Required]
        public string BloodType { get; set; }
        [Required,MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; }
        [Required,MaxLength(250)]
        public string Password { get; set; }   
        
    }
}