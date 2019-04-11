using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Domain.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupPicture { get; set; }
        public string Name { get; set; }
        public string MOTD { get; set; }


        public ICollection<GroupUserLink> GroupUserLinks { get; set; }
        public ICollection<JoinRequest> JoinRequests { get; set; }
    }
}
