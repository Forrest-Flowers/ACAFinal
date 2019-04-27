using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Data.Implementation.Mock
{
    public class MockEventRepository : IEventRepository
    {
        private List<Event> Events = new List<Event>();

        public Event Create(Event newEvent)
        {
            newEvent.Id = Events.OrderByDescending(e => e.Id).Single().Id + 1;
            Events.Add(newEvent);

            return newEvent;
        }

        public bool DeleteById(int eventId)
        {
            var GFevent = GetById(eventId);
            Events.Remove(GFevent);

            return true;
        }

        public Event GetById(int eventId)
        {
            return Events.Single(e => e.Id == eventId);
        }

        public ICollection<Event> GetByGroupId(int groupId)
        {
            return Events.FindAll(e => e.GroupId == groupId);
        }

        public Event Update(Event updatedEvent)
        {
            DeleteById(updatedEvent.Id);
            Events.Add(updatedEvent);

            return updatedEvent;
        }
    }
}
