using HealthyCook_Backend.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Domain.IRepositories
{
    public interface ICommentRepository
    {
        Task CreateComment(Comment comment);

        Task<List<Comment>> GetCommentById(int recipeID);

        Task AgregarLike(int commentId);

    }
}
