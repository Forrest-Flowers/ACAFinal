using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Domain.Models
{
    public class Date
    {
        public int Id { get; set; }
        public DateTime DayOfEvent { get; set; }
        public string Description { get; set; }

        public int PlannerId { get; set; }
        public Planner Planner { get; set; }
    }
}
