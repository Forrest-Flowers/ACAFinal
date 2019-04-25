using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Domain.Models
{
    public class User : IdentityUser
    { 
        public string ImageURL { get; set; }
        public string Bio { get; set; }

        public ICollection<GroupUserLink> GroupUserLinks { get; set; }
    }
}
