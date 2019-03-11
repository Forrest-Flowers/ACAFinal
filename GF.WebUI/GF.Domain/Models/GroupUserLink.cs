using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Domain.Models
{
    public class GroupUserLink
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string UserId { get; set; }

        public User User { get; set; } 
        public Group Group { get; set; }
    }
}
