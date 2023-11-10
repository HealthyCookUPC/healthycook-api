using HealthyCook_Backend.Domain.IServices;
using HealthyCook_Backend.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        public readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Comment comment)
        {
            try
            {
                await _commentService.CreateComment(comment);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("GetCommentById/{recipeID}")]
        [HttpGet]
        public async Task<IActionResult> GetCommentById(int recipeID)
        {
            try
            {
                var commentList = _commentService.GetCommentById(recipeID);
                return Ok(commentList.Result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }


}
