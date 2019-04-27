using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Data.Interfaces
{
    public interface IGroupRepository
    {
        //Create
        Group Create(Group newGroup);

        //Read
        Group GetById(int groupId);
        ICollection<Group> GetAll();
        ICollection<Group> GetByUserId(string userId);

        //Update
        Group Update(Group updatedGroup);

        //Delete
        bool DeleteById(int groupId);
    }
}
