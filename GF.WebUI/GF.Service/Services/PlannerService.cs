using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Service.Services
{
    public interface IPlannerService
    {
        Planner Create(Planner newPlanner);
        Planner GetById(int plannerId);
        ICollection<Planner> GetByGroupId(int groupId);
        Planner Update(Planner updatedPlanner);
        bool DeleteById(int plannerId);
    }

    public class PlannerService : IPlannerService
    {
        private IPlannerRepository _plannerRepository;

        public PlannerService(IPlannerRepository plannerRepository) =>
            _plannerRepository = plannerRepository;

        public Planner Create(Planner newPlanner) =>
            _plannerRepository.Create(newPlanner);

        public bool DeleteById(int plannerId) =>
            _plannerRepository.DeleteById(plannerId);

        public ICollection<Planner> GetByGroupId(int groupId) =>
            _plannerRepository.GetByGroupId(groupId);

        public Planner GetById(int plannerId) =>
            _plannerRepository.GetById(plannerId);

        public Planner Update(Planner updatedPlanner) =>
            _plannerRepository.Update(updatedPlanner);
    }
}
