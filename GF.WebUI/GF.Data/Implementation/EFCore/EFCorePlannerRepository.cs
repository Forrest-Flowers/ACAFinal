using GF.Data.Context;
using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Data.Implementation.EFCore
{
    public class EFCorePlannerRepository : IPlannerRepository
    {
        public Planner Create(Planner newPlanner)
        {
            using (var context = new GFDbContext())
            {
                context.Planners.Add(newPlanner);
                context.SaveChanges();

                return newPlanner;
            }
        }

        public bool DeleteById(int plannerId)
        {
            using (var context = new GFDbContext())
            {
                var planner = GetById(plannerId);
                context.Remove(planner);
                context.SaveChanges();

                if(GetById(plannerId) == null)
                {
                    return true;
                }
                return false;
            }
        }

        public ICollection<Planner> GetByGroupId(int groupId)
        {
            using (var context = new GFDbContext())
            {
                return context.Planners.Where(p => p.GroupId == groupId).ToList();
            }
        }

        public Planner GetById(int plannerId)
        {
            using (var context = new GFDbContext())
            {
                return context.Planners.Single(p => p.Id == plannerId);
            }
        }

        public Planner Update(Planner updatedPlanner)
        {
            using (var context = new GFDbContext())
            {
                var existingPlanner = GetById(updatedPlanner.Id);
                context.Entry(existingPlanner).CurrentValues.SetValues(updatedPlanner);
                context.SaveChanges();

                return existingPlanner;
            }
        }
    }
}
