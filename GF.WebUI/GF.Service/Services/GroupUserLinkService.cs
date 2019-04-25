using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Service.Services
{
    public interface IGroupUserLinkService
    {
        GroupUserLink Create(GroupUserLink newGroupUserLink);
        GroupUserLink GetById(int Id);
        ICollection<GroupUserLink> GetByGroupId(int groupId);
        ICollection<GroupUserLink> GetByUserId(string userId);
        GroupUserLink Update(GroupUserLink updatedGroupUserLink);
        bool DeleteById(int Id);
    }

    public class GroupUserLinkService : IGroupUserLinkService
    {
        private readonly IGroupUserLinkRepository _groupUserLinkRepository;

        public GroupUserLinkService(IGroupUserLinkRepository groupUserLinkRepository) =>
            _groupUserLinkRepository = groupUserLinkRepository;

        public GroupUserLink Create(GroupUserLink newGroupUserLink) =>
            _groupUserLinkRepository.Create(newGroupUserLink);


        public bool DeleteById(int Id) =>
            _groupUserLinkRepository.DeleteById(Id);

        public ICollection<GroupUserLink> GetByGroupId(int groupId) =>
            _groupUserLinkRepository.GetByGroupId(groupId);

        public GroupUserLink GetById(int Id) =>
            _groupUserLinkRepository.GetById(Id);

        public ICollection<GroupUserLink> GetByUserId(string userId) =>
            _groupUserLinkRepository.GetByUserId(userId);

        public GroupUserLink Update(GroupUserLink updatedGroupUserLink) =>
            _groupUserLinkRepository.Update(updatedGroupUserLink);
    }
}
