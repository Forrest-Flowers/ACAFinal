using GF.Data.Context;
using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Data.Implementation.EFCore
{
    public class EFCoreJoinRequestStatusRepository : IJoinRequestStatusRepository
    {
        public ICollection<JoinRequestStatus> GetAll()
        {
            using (var context = new GFDbContext())
            {
                var alljrs = context.JoinRequestStatuses.ToList();

                return alljrs;
            }
        }

        public JoinRequestStatus GetById(int joinRequestStatusId)
        {
            using (var context = new GFDbContext())
            {
                return context.JoinRequestStatuses.Single(ms => ms.Id == joinRequestStatusId);
            }
        }
    }
}
