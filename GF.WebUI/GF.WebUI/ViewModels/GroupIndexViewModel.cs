using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GF.WebUI.ViewModels
{
    public class GroupIndexViewModel
    {
        public Group Group { get; set; }
        public Planner Planner { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
