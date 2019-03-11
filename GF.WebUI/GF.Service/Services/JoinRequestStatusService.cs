using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Service.Services
{
    public interface IJoinRequestStatusService
    {
        JoinRequestStatus GetById(int joinRequestStatus);
        ICollection<JoinRequestStatus> GetAll();
    }
   public class JoinRequestStatusService : IJoinRequestStatusService
    {
        private readonly IJoinRequestStatusService _joinRequestStatusService;

        public JoinRequestStatusService(IJoinRequestStatusService joinRequestStatusService) =>
            _joinRequestStatusService = joinRequestStatusService;

        public ICollection<JoinRequestStatus> GetAll() =>
            _joinRequestStatusService.GetAll();

        public JoinRequestStatus GetById(int joinRequestStatus) =>
            _joinRequestStatusService.GetById(joinRequestStatus);
    }
}
