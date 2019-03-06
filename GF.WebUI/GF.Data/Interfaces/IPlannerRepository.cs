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
        Planner GetByGroupId(int groupId);
        Planner GetByDateId(int dateId);

        //Update
        Planner Update(Planner updatedPlanner);

        //Delete
        bool DeleteById(int PlannerId);
    }
}
