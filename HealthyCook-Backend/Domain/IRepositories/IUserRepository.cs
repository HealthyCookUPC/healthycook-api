using HealthyCook_Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Domain.IRepositories
{
    public interface IUserRepository
    {
        Task SaveUser(User user);
        Task<bool> ValidateExistence(User user);
        Task<bool> ValidateEmail(string email);
        Task<User> SearchUser(int userID);
        Task<User> UpdateUserImage(int userID, string imageUrl);
        Task<int> LoginUser(Login login);
        Task DeleteUser(User user);
    }
}
