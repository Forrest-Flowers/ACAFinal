using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Domain.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ScreenName { get; set; }
        public string ProfilePicture { get; set; }


        ICollection<Group> Groups { get; set; }
    }
}
