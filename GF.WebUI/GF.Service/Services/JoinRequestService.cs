using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Service.Services
{
    public interface IJoinRequestService
    {
        JoinRequest Create(JoinRequest newJoinRequest);
        JoinRequest GetById(int joinRequestId);
        ICollection<JoinRequest> GetByUserId(string userId);
        ICollection<JoinRequest> GetByGroupId(int groupId);
        JoinRequest Update(JoinRequest updatedJoinRequest);
        bool DeleteById(int joinRequestId);
    }

    public class JoinRequestService : IJoinRequestService
    {
        private readonly IJoinRequestRepository _joinRequestRepository;

        public JoinRequestService(IJoinRequestRepository joinRequestRepository) =>
            _joinRequestRepository = joinRequestRepository;

        public JoinRequest Create(JoinRequest newJoinRequest) =>
            _joinRequestRepository.Create(newJoinRequest);

        public bool DeleteById(int joinRequestId) =>
            _joinRequestRepository.DeleteById(joinRequestId);

        public ICollection<JoinRequest> GetByGroupId(int groupId) =>
            _joinRequestRepository.GetByGroupId(groupId);

        public JoinRequest GetById(int joinRequestId) =>
            _joinRequestRepository.GetById(joinRequestId);

        public ICollection<JoinRequest> GetByUserId(string userId) =>
            _joinRequestRepository.GetByUserId(userId);

        public JoinRequest Update(JoinRequest updatedJoinRequest) =>
            _joinRequestRepository.Update(updatedJoinRequest);
    }
}
