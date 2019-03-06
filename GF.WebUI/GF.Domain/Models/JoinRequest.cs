using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Domain.Models
{
    public class JoinRequest
    {
        public int Id{ get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public int JoinRequestStatusId { get; set; }
        public JoinRequestStatus JoinRequestStatus { get; set; }
    }
}
