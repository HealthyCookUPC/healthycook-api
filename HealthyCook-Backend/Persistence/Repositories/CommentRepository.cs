using HealthyCook_Backend.Domain.IRepositories;
using HealthyCook_Backend.Domain.Models;
using HealthyCook_Backend.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Persistence.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AplicationDbContext _context;

        public CommentRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateComment(Comment comment)
        {
            _context.Add(comment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Comment>> GetCommentById(int recipeID)
        {
            var comment = await _context.Comment
                .Where(x => x.RecipeID == recipeID)
                .ToListAsync();
            return comment;
        }
    }
}
