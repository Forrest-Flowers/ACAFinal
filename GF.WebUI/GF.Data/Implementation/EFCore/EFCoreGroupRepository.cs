using GF.Data.Context;
using GF.Data.Interfaces;
using GF.Domain.Models;
using Microsoft.EntityFrameworkCore;
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
                var group = context.Groups.Include(g => g.Events).SingleOrDefault(g => g.Id == groupId);
                return group;
            }
        }

        public ICollection<Group> GetByUserId(string userId)
        {
            using (var context = new GFDbContext())
            {
                var groupUserLinks = context.GroupUserLinks.Where(gu => gu.UserId == userId);

                return context.Groups.Where(g => g.GroupUserLinks == groupUserLinks).ToList();

            }
        }

        public Group Update(Group Group)
        {
            using (var context = new GFDbContext())
            {
                var existingGroup = GetById(Group.Id);

                context.Update(Group);
                context.SaveChanges();

                return Group;
            }
        }
    }
}
