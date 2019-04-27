using GF.Data.Context;
using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Data.Implementation.EFCore
{
    public class EFCoreEventRepository : IEventRepository
    {
        public Event Create(Event newEvent)
        {
            using (var context = new GFDbContext())
            {
                context.Events.Add(newEvent);
                context.SaveChanges();

                return newEvent;
            }
        }

        public bool DeleteById(int eventId)
        {
            using (var context = new GFDbContext())
            {
                var GFevent = GetById(eventId);
                context.Remove(GFevent);
                context.SaveChanges();

                if(GetById(eventId) == null)
                {
                    return true;
                }
                return false;
            }
        }

        public Event GetById(int eventId)
        {
            using (var context = new GFDbContext())
            {
                return context.Events.Single(e => e.Id == eventId);
            }
        }

        public ICollection<Event> GetByGroupId(int GroupId)
        {
            using (var context = new GFDbContext())
            {
                return context.Events.Where(e => e.GroupId == GroupId).ToList();
            }
        }

        public Event Update(Event updatedEvent)
        {
            using (var context = new GFDbContext())
            {
                var existingEvent = GetById(updatedEvent.Id);
                context.Entry(existingEvent).CurrentValues.SetValues(updatedEvent);
                context.SaveChanges();

                return existingEvent;
            }
        }
    }
}
