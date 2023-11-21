﻿using HealthyCook_Backend.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Domain.IServices
{
    public interface IFollowersService
    {
        Task CreateFollower(Followers followers);
        Task<List<FollowersDTO>> GetFollowersByUser(int userId);
        Task<List<FollowersDTO>> GetFollowedsByUser(int userId);
        Task<int> GetFollowersCountByUser(int userId);
        Task<int> GetFollowedsCountByUser(int userId);
    }
}
