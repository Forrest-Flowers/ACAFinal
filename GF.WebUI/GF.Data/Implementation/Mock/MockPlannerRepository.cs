using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Data.Implementation.Mock
{
    public class MockPlannerRepository : IPlannerRepository
    {
        private List<Planner> Planners = new List<Planner>();

        public Planner Create(Planner newPlanner)
        {
            newPlanner.Id = Planners.OrderByDescending(p => p.Id).Single().Id + 1;
            Planners.Add(newPlanner);

            return newPlanner;
        }

        public bool DeleteById(int plannerId)
        {
            var planner = GetById(plannerId);
            Planners.Remove(planner);

            return true;
        }

        public Planner GetById(int plannerId)
        {
            return Planners.Single(p => p.Id == plannerId);
        }

        public Planner Update(Planner updatedPlanner)
        {
            DeleteById(updatedPlanner.Id);
            Planners.Add(updatedPlanner);

            return updatedPlanner;
        }

        public ICollection<Planner> GetByGroupId(int groupId)
        {
            return Planners.FindAll(p => p.GroupId == groupId); 
        }
    }
}
