using GF.Data.Context;
using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Data.Implementation.EFCore
{
    public class EFCoreJoinRequestStatusRepository : IJoinRequestRepository
    {
        public JoinRequest Create(JoinRequest newJoinRequest)
        {
            using (var context = new GFDbContext())
            {
                context.JoinRequests.Add(newJoinRequest);
                context.SaveChanges();

                return newJoinRequest;
            }
        }

        public bool DeleteById(int joinRequestId)
        {
            using (var context = new GFDbContext())
            {
                var joinRequest = GetById(joinRequestId);
                context.Remove(joinRequest);
                context.SaveChanges();

                if(GetById(joinRequestId) == null)
                {
                    return true;
                }
                return false;
            }
        }

        public ICollection<JoinRequest> GetByGroupId(int groupId)
        {
            using (var context = new GFDbContext())
            {
                return context.JoinRequests.Where(jr => jr.GroupId == groupId).ToList();
            }
        }

        public JoinRequest GetById(int joinRequestId)
        {
            using (var context = new GFDbContext())
            {
                return context.JoinRequests.Single(jr => jr.Id == joinRequestId);
            }
        }

        public ICollection<JoinRequest> GetByUserId(string userId)
        {
            using (var context = new GFDbContext())
            {
                return context.JoinRequests.Where(jr => jr.UserId == userId).ToList();
            }
        }

        public JoinRequest Update(JoinRequest updatedJoinRequest)
        {
            using (var context = new GFDbContext())
            {
                var existingJoinRequest = GetById(updatedJoinRequest.Id);
                context.Entry(existingJoinRequest).CurrentValues.SetValues(updatedJoinRequest);
                context.SaveChanges();

                return existingJoinRequest;
            }
        }
    }
}
