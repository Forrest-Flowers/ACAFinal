using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Domain.Models
{
    public class Planner
    {
        public int Id { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        IEnumerable<Event> Events { get; set; }
    }
}
