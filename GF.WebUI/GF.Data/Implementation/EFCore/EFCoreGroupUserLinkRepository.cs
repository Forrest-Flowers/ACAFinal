using GF.Data.Context;
using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Data.Implementation.EFCore
{
    public class EFCoreGroupUserLinkRepository : IGroupUserLinkRepository
    {
        public GroupUserLink Create(GroupUserLink newGroupUserLink)
        {
            using (var context = new GFDbContext())
            {
                context.GroupUserLinks.Add(newGroupUserLink);
                context.SaveChanges();

                return newGroupUserLink;
            }
        }

        public bool DeleteById(int Id)
        {
            using (var context = new GFDbContext())
            {
                var groupUserLink = GetById(Id);
                context.Remove(groupUserLink);
                context.SaveChanges();

                if (GetById(Id) == null)
                {
                    return true;
                }
                return false;
            }
        }

        public ICollection<GroupUserLink> GetByGroupId(int groupId)
        {
            using (var context = new GFDbContext())
            {
                return context.GroupUserLinks.Where(gu => gu.GroupId == groupId).ToList();
            }
        }

        public GroupUserLink GetById(int Id)
        {
            using (var context = new GFDbContext())
            {
                return context.GroupUserLinks.SingleOrDefault(gu => gu.Id == Id);
            }
        }

        public ICollection<GroupUserLink> GetByUserId(string userId)
        {
            using (var context = new GFDbContext())
            {
                return context.GroupUserLinks.Where(gu => gu.UserId == userId).ToList();
            }
        }

        public GroupUserLink Update(GroupUserLink updatedGroupUserLink)
        {
            using (var context = new GFDbContext())
            {
                var existingGroupUserLink = GetById(updatedGroupUserLink.Id);
                context.Entry(existingGroupUserLink).CurrentValues.SetValues(updatedGroupUserLink);
                context.SaveChanges();

                return existingGroupUserLink;
            }
        }
    }
}
