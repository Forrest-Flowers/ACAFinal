using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Domain.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string MOTD { get; set; }


        public List<GroupUserLink> GroupUserLinks { get; set; }
        public List<JoinRequest> JoinRequests { get; set; }
        public List<Event> Events { get; set; }
    }
}
