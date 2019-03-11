using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Service.Services
{
    public interface IGroupService
    {
        Group Create(Group newGroup);
        Group GetById(int groupId);
        Group Update(Group updatedGroup);
        bool DeleteById(int groupId);
    }
    public class GroupService : IGroupService
    {
        private readonly IGroupService _groupService;

        public GroupService(IGroupService groupService) =>
            _groupService = groupService;

        public Group Create(Group newGroup) =>
            _groupService.Create(newGroup);

        public bool DeleteById(int groupId) =>
            _groupService.DeleteById(groupId);

        public Group GetById(int groupId) =>
            _groupService.GetById(groupId);

        public Group Update(Group updatedGroup) =>
            _groupService.Update(updatedGroup);
    }
}
