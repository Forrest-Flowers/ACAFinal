using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Service.Services
{
    public interface IUserService
    {
        User Create(User newUser);
        User GetById(string userId);
        User Update(User updatedUser);
        bool DeleteById(string userId);
    }
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) =>
             _userRepository = userRepository;

        public User Create(User newUser) =>
            _userRepository.Create(newUser);

        public bool DeleteById(string userId) =>
           _userRepository.DeleteById(userId);

        public User GetById(string userId) =>
            _userRepository.GetById(userId);

        public User Update(User updatedUser) =>
            _userRepository.Update(updatedUser);
    }
}
