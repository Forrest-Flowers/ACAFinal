using GF.Data.Interfaces;
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
        ICollection<Group> GetAll();
        ICollection<Group> GetByUserId(string userId);
        Group Update(Group updatedGroup);
        bool DeleteById(int groupId);
    }
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _groupRepository;

        public GroupService(IGroupRepository groupRepository) =>
            _groupRepository = groupRepository;

        public Group Create(Group newGroup) =>
            _groupRepository.Create(newGroup);

        public bool DeleteById(int groupId) =>
            _groupRepository.DeleteById(groupId);

        public ICollection<Group> GetAll() =>
            _groupRepository.GetAll();

        public ICollection<Group> GetByUserId(string userId) =>
            _groupRepository.GetByUserId(userId);

        public Group GetById(int groupId) =>
            _groupRepository.GetById(groupId);

        public Group Update(Group updatedGroup) =>
            _groupRepository.Update(updatedGroup);
    }
}
