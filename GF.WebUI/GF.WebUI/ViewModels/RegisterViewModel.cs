using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GF.WebUI.ViewModels
{
    public class RegisterViewModel
    {
        [EmailAddress, Required]
        [Display(Prompt = "Email Address")]
        public string Email { get; set; }

        [DataType(DataType.Password), Required]
        [Display(Prompt = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare("Password", ErrorMessage = "Passwords Don't Match"), Required]
        [Display(Prompt = "Confirm Password")]
        public string ConfirmedPassword { get; set; }
    }
}
