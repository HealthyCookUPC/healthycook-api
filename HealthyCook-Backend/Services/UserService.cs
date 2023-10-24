﻿using HealthyCook_Backend.Domain.IRepositories;
using HealthyCook_Backend.Domain.IServices;
using HealthyCook_Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task DeleteUser(User user)
        {
            await _userRepository.DeleteUser(user);
        }

        public async Task<int> LoginUser(Login login)
        {
            return await _userRepository.LoginUser(login);
        }

        public async Task SaveUser(User user)
        {
            await _userRepository.SaveUser(user);
        }

        public async Task<User> SearchUser(int userID)
        {
            return await _userRepository.SearchUser(userID);
        }

        public async Task<User> UpdateUserImage(int userID, string imageUrl)
        {
            return await _userRepository.UpdateUserImage(userID, imageUrl);
        }

        public async Task<bool> ValidateEmail(string email)
        {
            return await _userRepository.ValidateEmail(email);
        }

        public async Task<bool> ValidateExistence(User user)
        {
            return await _userRepository.ValidateExistence(user);
        }
    }
}
