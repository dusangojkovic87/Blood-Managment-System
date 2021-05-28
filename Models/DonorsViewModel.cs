using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DonateBlood.Models
{
    
    public class DonorsViewModel
    {
        public DonorsViewModel()
        {
            BloodList = new List<SelectListItem>{
               new SelectListItem {Text = "A+",Value ="A+"},
               new SelectListItem {Text = "A-",Value ="A-"},
               new SelectListItem {Text = "B+",Value ="B+"},
               new SelectListItem {Text = "B-",Value ="B-"},
               new SelectListItem {Text = "AB+",Value ="AB-"},
               new SelectListItem {Text = "AB-",Value ="AB-"},
               new SelectListItem {Text = "0+",Value ="0+"},
               new SelectListItem {Text = "0-",Value ="0+"}
            };   
        }
        
        public IEnumerable<AplicationUser> Donors{get;set;}
        public List<SelectListItem> BloodList { get; set; }
    }
}