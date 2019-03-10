using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Data.Implementation.EFCore
{
    public class EFCoreJoinRequestRepository : IJoinRequestRepository
    {
        public JoinRequest Create(JoinRequest newJoinRequest)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int joinRequestId)
        {
            throw new NotImplementedException();
        }

        public ICollection<JoinRequest> GetByGroupId(int groupId)
        {
            throw new NotImplementedException();
        }

        public JoinRequest GetById(int joinRequestId)
        {
            throw new NotImplementedException();
        }

        public ICollection<JoinRequest> GetByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public JoinRequest Update(JoinRequest updatedJoinRequest)
        {
            throw new NotImplementedException();
        }
    }
}
