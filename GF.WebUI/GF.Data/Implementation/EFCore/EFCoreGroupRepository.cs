using GF.Data.Context;
using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Data.Implementation.EFCore
{
    public class EFCoreGroupRepository : IGroupRepository
    {
        public Group Create(Group newGroup)
        {
            using (var context = new GFDbContext())
            {
                context.Groups.Add(newGroup);
                context.SaveChanges();

                return newGroup;
            }
        }

        public bool DeleteById(int groupId)
        {
            using (var context = new GFDbContext())
            {
                var group = GetById(groupId);
                context.Remove(group);
                context.SaveChanges();

                if(GetById(groupId) == null)
                {
                    return true;
                }
                return false;
            }
        }

        public ICollection<Group> GetAll()
        {
            using (var context = new GFDbContext())
            {
                var allGroups = context.Groups.ToList();

                return allGroups;
            }
        }

        public Group GetById(int groupId)
        {
            using (var context = new GFDbContext())
            {
                return context.Groups.Single(g => g.Id == groupId);
            }
        }

        public Group Update(Group updatedGroup)
        {
            using (var context = new GFDbContext())
            {
                var existingGroup = GetById(updatedGroup.Id);
                context.Entry(existingGroup).CurrentValues.SetValues(updatedGroup);
                context.SaveChanges();

                return existingGroup;
            }
        }
    }
}
