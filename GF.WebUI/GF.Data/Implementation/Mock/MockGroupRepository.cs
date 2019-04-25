using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Data.Implementation.Mock
{
    public class MockGroupRepository : IGroupRepository
    {
        private List<Group> Groups = new List<Group>();

        public Group Create(Group newGroup)
        {
            newGroup.Id = Groups.OrderByDescending(g => g.Id).Single().Id + 1;
            Groups.Add(newGroup);

            return newGroup;
        }

        public bool DeleteById(int groupId)
        {
            var group = GetById(groupId);
            Groups.Remove(group);

            return true;
        }

        public ICollection<Group> GetAll()
        {
            throw new NotImplementedException();
        }

        public Group GetById(int groupId)
        {
            return Groups.Single(g => g.Id == groupId);
        }

        public Group Update(Group updatedGroup)
        {
            DeleteById(updatedGroup.Id);
            Groups.Add(updatedGroup);

            return updatedGroup;
        }
    }
}
