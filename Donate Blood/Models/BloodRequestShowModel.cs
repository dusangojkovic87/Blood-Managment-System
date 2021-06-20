using System;
using System.ComponentModel.DataAnnotations;

namespace DonateBlood.Models
{
    public class BloodRequestShowModel
    {
        public int Id { get; set; }
        [Required]
        public string BloodType { get; set; }
        [Required]
        public string DonateLocation { get; set; }
        [Required(ErrorMessage = "Donate Location required"),MaxLength(500)]
        public string BloodReqDesc { get; set; }
        public DateTime CreatedAt { get; set; }
        public int AplicationUserId { get; set; }
        public AplicationUser User { get; set; }
        [Required]
        public string ProfileImg { get; set; }
        
    }
}