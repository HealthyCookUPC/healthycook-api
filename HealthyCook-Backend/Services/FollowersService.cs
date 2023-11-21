using HealthyCook_Backend.Domain.IRepositories;
using HealthyCook_Backend.Domain.IServices;
using HealthyCook_Backend.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Services
{
    public class FollowersService : IFollowersService
    {
        private readonly IFollowersRepository _followersRepository;
        public FollowersService(IFollowersRepository followersRepository)
        {
            _followersRepository = followersRepository;
        }

        public async Task CreateFollower(Followers followers)
        {
            await _followersRepository.CreateFollower(followers);
        }

        public async Task<List<FollowersDTO>> GetFollowedsByUser(int userId)
        {
            return await _followersRepository.GetFollowedsByUser(userId);
        }

        public async Task<int> GetFollowedsCountByUser(int userId)
        {
            return await _followersRepository.GetFollowedsCountByUser(userId);
        }

        public async Task<List<FollowersDTO>> GetFollowersByUser(int userId)
        {
            return await _followersRepository.GetFollowersByUser(userId);
        }

        public async Task<int> GetFollowersCountByUser(int userId)
        {
            return await _followersRepository.GetFollowersCountByUser(userId);
        }
    }
}
