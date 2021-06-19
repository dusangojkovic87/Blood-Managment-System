using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DonateBlood.Models
{
    public class AplicationUser:IdentityUser<int>
    {
        public AplicationUser()
        {
            ProfileImg = "images/default/defaultProfileImage.png";      
        }

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
        public override string Email { get; set; }
        [Required,MaxLength(250)]
        public string Password { get; set; }  
        public string ProfileImg {get;set;} 
        public int InboxId { get; set; }
        public int BloodRequestId { get; set; }
        ICollection<Inbox> Inbox {get;set;}
        ICollection<BloodRequest> BloodRequest {get;set;}
    }
}