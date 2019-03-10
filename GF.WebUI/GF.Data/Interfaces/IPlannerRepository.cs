using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Data.Interfaces
{
    public interface IPlannerRepository
    {
        //Create
        Planner Create(Planner newPlanner);

        //Read
        Planner GetById(int plannerId);
        ICollection<Planner> GetByGroupId(int groupId);
        //Update
        Planner Update(Planner updatedPlanner);

        //Delete
        bool DeleteById(int plannerId);
    }
}
