using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GF.Domain.Models
{
    public class Event
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DayOfEvent { get; set; }

        public string Description { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
