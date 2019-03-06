using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Data.Interfaces
{
    public interface IJoinRequestRepository
    {
        //Create
        JoinRequest Create(JoinRequest newJoinRequest);

        //Read
        JoinRequest GetById(int joinRequestId);
        ICollection<JoinRequest> GetByUserId(string userId);
        ICollection<JoinRequest> GetByGroupId(int groupId);

        //Update
        JoinRequest Update(JoinRequest updatedJoinRequest);

        //Delete
        bool DeleteById(int joinRequestId);
    }
}
