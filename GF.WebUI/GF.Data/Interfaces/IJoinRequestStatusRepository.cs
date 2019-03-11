using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Data.Interfaces
{
    public interface IJoinRequestStatusRepository
    {
        //Read-Only

        JoinRequestStatus GetById(int joinRequestStatuId);
        ICollection<JoinRequestStatus> GetAll();
    }
}
