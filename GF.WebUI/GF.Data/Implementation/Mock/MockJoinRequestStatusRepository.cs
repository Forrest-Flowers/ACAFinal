using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Data.Implementation.Mock
{
    public class MockJoinRequestStatusRepository : IJoinRequestStatusRepository
    {
        private List<JoinRequestStatus> JoinRequestStatuses = new List<JoinRequestStatus>();
        public ICollection<JoinRequestStatus> GetAll()
        {
            var all = JoinRequestStatuses.Select(jrs => jrs.Id).ToList();
            return all as ICollection<JoinRequestStatus>;
        }

        public JoinRequestStatus GetById(int joinRequestStatusId)
        {
            return JoinRequestStatuses.Single(jrs => jrs.Id == joinRequestStatusId);
        }
    }
}
