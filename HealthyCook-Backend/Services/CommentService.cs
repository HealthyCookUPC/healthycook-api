using HealthyCook_Backend.Domain.IRepositories;
using HealthyCook_Backend.Domain.IServices;
using HealthyCook_Backend.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public async Task CreateComment(Comment comment)
        {
            await _commentRepository.CreateComment(comment);
        }

        public async Task<List<Comment>> GetCommentById(int recipeID)
        {
            return await _commentRepository.GetCommentById(recipeID);
        }
    }
}
