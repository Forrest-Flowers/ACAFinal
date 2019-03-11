using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GF.WebUI.ViewModels
{
    public class RegisterViewModel
    {
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password), Compare("Password", ErrorMessage = "Passwords don't match!")]
        public string ConfirmedPassword { get; set; }
    }
}
