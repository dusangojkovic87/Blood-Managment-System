using System;
using System.ComponentModel.DataAnnotations;

namespace DonateBlood.Models
{
    public class Inbox
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string message { get; set; }
        [Required]
        public string sender { get; set; }
        public DateTime dateSent { get; set; }
        public int AplicationUserId { get; set; }
        public AplicationUser User { get; set; }
        
    }
}