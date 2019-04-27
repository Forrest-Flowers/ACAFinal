using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Service.Services
{
    public interface IEventService
    {
        Event Create(Event newEvent);
        Event GetById(int eventId);
        ICollection<Event> GetByGroupId(int groupId);
        Event Update(Event updatedEvent);
        bool DeleteById(int eventId);
    }

    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository) =>
            _eventRepository = eventRepository;

        public Event Create(Event newEvent) =>
            _eventRepository.Create(newEvent);

        public bool DeleteById(int eventId) =>
            _eventRepository.DeleteById(eventId);

        public Event GetById(int eventId) =>
            _eventRepository.GetById(eventId);

        public ICollection<Event> GetByGroupId(int groupId) =>
            _eventRepository.GetByGroupId(groupId);

        public Event Update(Event updatedEvent) =>
            _eventRepository.Update(updatedEvent);
    }
}
