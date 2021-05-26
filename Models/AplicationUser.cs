using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DonateBlood.Models
{
    public class AplicationUser:IdentityUser
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
        [Required,MaxLength(250)]
        public string Password { get; set; }   
    }
}