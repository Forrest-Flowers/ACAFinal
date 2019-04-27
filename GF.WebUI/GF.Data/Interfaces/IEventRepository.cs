using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Data.Interfaces
{
    public interface IEventRepository
    {
        //Create
        Event Create(Event newEvent);

        //Read
        Event GetById(int eventId);
        ICollection<Event> GetByGroupId(int GroupId);

        //Update
        Event Update(Event updatedEvent);

        //Delete
        bool DeleteById(int eventId);
    }
}
