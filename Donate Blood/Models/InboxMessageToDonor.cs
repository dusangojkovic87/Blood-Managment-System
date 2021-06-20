using System.ComponentModel.DataAnnotations;

namespace DonateBlood.Models
{
    public class InboxMessageToDonor
    {
        [Required]
        public string message { get; set; }
        [Required]
        public string donorId { get; set; }
         [Required]
        public string senderName { get; set; }
    }
}