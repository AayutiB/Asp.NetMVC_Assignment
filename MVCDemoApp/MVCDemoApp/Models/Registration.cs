using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "UserName")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Email...")]
        [Display(Name = "Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter your phone number...")]
        [Display(Name = "PhoneNo")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = "Please specify wheather you will attend")]
        [Display(Name = "WillAttend")]
        public string WillAttend { get; set; }

    }
}
