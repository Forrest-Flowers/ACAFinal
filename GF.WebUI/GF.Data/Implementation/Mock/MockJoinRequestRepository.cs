using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Data.Implementation.Mock
{
    public class MockJoinRequestRepository : IJoinRequestRepository
    {
        private List<JoinRequest> JoinRequests = new List<JoinRequest>();

        public JoinRequest Create(JoinRequest newJoinRequest)
        {
            newJoinRequest.Id = JoinRequests.OrderByDescending(jr => jr.Id).Single().Id + 1;
            JoinRequests.Add(newJoinRequest);

            return newJoinRequest;
        }

        public bool DeleteById(int joinRequestId)
        {
            var joinrequest = GetById(joinRequestId);
            JoinRequests.Remove(joinrequest);

            return true;
        }

        public ICollection<JoinRequest> GetByGroupId(int groupId)
        {
            return JoinRequests.FindAll(jr => jr.GroupId == groupId);
        }

        public JoinRequest GetById(int joinRequestId)
        {
            return JoinRequests.Single(jr => jr.Id == joinRequestId);
        }

        public ICollection<JoinRequest> GetByUserId(string userId)
        {
            return JoinRequests.FindAll(jr => jr.UserId == userId);
        }

        public JoinRequest Update(JoinRequest updatedJoinRequest)
        {
            DeleteById(updatedJoinRequest.Id);
            JoinRequests.Add(updatedJoinRequest);

            return updatedJoinRequest;
        }
    }
}
