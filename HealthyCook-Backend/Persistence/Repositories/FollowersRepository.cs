using HealthyCook_Backend.Domain.IRepositories;
using HealthyCook_Backend.Domain.Models;
using HealthyCook_Backend.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Persistence.Repositories
{
    public class FollowersRepository : IFollowersRepository
    {
        private readonly AplicationDbContext _context;
        public FollowersRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateFollower(Followers followers)
        {
            _context.Add(followers);
            await _context.SaveChangesAsync();
        }

        public async Task<List<FollowersDTO>> GetFollowedsByUser(int userId)
        {
            var usersFolloweds = await _context.Followers
                .Where(x => x.UserID == userId)
                .Select(f => new Followers
                {
                    ID = f.ID,
                    UserID = f.UserID,
                    User = new User
                    {
                        ID = f.User.ID,
                        Username = f.User.Username
                    },
                    FollowedUserID = f.FollowedUserID,
                    FollowedUser = new User
                    {
                        ID = f.FollowedUser.ID,
                        Username = f.FollowedUser.Username

                    }
                })
                .ToListAsync();
            List<FollowersDTO> followersDTOs = new List<FollowersDTO>();
            usersFolloweds.ForEach(x =>
            {
                FollowersDTO item = new FollowersDTO();
                item.FollowedUserID = x.FollowedUserID;
                item.FollowedUsername = x.FollowedUser.Username;
                item.UserID = x.UserID;
                item.FollowerUsername = x.User.Username;
                followersDTOs.Add(item);
            });
            return followersDTOs;
        }

        public async Task<int> GetFollowedsCountByUser(int userId)
        {
            var usersFolloweds = await _context.Followers
                .Where(x => x.UserID == userId)
                .Select(f => new Followers
                {
                    ID = f.ID,
                    UserID = f.UserID,
                    User = new User
                    {
                        ID = f.User.ID,
                        Username = f.User.Username
                    },
                    FollowedUserID = f.FollowedUserID,
                    FollowedUser = new User
                    {
                        ID = f.FollowedUser.ID,
                        Username = f.FollowedUser.Username

                    }
                })
                .CountAsync();
            return usersFolloweds;
        }

        public async Task<List<FollowersDTO>> GetFollowersByUser(int userId)
        {
            var usersFollowers = await _context.Followers
                .Where(x => x.FollowedUserID == userId)
                .Select(f => new Followers
                {
                    ID = f.ID,
                    UserID = f.UserID,
                    User = new User
                    {
                        ID = f.User.ID,
                        Username = f.User.Username
                    },
                    FollowedUserID = f.FollowedUserID,
                    FollowedUser = new User
                    {
                        ID = f.FollowedUser.ID,
                        Username = f.FollowedUser.Username

                    }
                })
                .ToListAsync();
            List<FollowersDTO> followersDTOs = new List<FollowersDTO>();
            usersFollowers.ForEach(x =>
            {
                FollowersDTO item = new FollowersDTO();
                item.FollowedUserID = x.FollowedUserID;
                item.FollowedUsername = x.FollowedUser.Username;
                item.UserID = x.UserID;
                item.FollowerUsername = x.User.Username;
                followersDTOs.Add(item);
            });
            return followersDTOs;
        }

        public async Task<int> GetFollowersCountByUser(int userId)
        {
            var usersFollowers = await _context.Followers
                .Where(x => x.FollowedUserID == userId)
                .Select(f => new Followers
                {
                    ID = f.ID,
                    UserID = f.UserID,
                    User = new User
                    {
                        ID = f.User.ID,
                        Username = f.User.Username
                    },
                    FollowedUserID = f.FollowedUserID,
                    FollowedUser = new User
                    {
                        ID = f.FollowedUser.ID,
                        Username = f.FollowedUser.Username

                    }
                })
                .CountAsync();
            return usersFollowers;
        }
    }
}
