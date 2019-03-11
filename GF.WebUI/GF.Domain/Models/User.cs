using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Domain.Models
{
    public class User : IdentityUser
    { 
        public string ProfilePicture { get; set; }
        public string Bio { get; set; }

        ICollection<Group> Groups { get; set; }
    }
}
