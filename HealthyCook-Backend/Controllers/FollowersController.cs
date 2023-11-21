using HealthyCook_Backend.Domain.IServices;
using HealthyCook_Backend.Domain.Models;
using HealthyCook_Backend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace HealthyCook_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowersController : ControllerBase
    {
        private readonly IFollowersService _followersService;
        public FollowersController(IFollowersService followersService)
        {
            _followersService = followersService;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Followers followers)
        {
            try
            { 
                await _followersService.CreateFollower(followers);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("GetFollowersByUser/{userId}")]
        [HttpGet]
        public async Task<IActionResult> GetFollowersByUser(int userId)
        {
            try
            {
                var followerList = await _followersService.GetFollowersByUser(userId);
                return Ok(followerList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("GetFollowedsByUser/{userId}")]
        [HttpGet]
        public async Task<IActionResult> GetFollowedsByUser(int userId)
        {
            try
            {
                var followerList = await _followersService.GetFollowedsByUser(userId);
                return Ok(followerList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("GetFollowersCountByUser/{userId}")]
        [HttpGet]
        public async Task<int> GetFollowersCountByUser(int userId)
        {
            var followerList = await _followersService.GetFollowersCountByUser(userId);
            return followerList;
        }
        [Route("GetFollowedsCountByUser/{userId}")]
        [HttpGet]
        public async Task<int> GetFollowedsCountByUser(int userId)
        {
            var followerList = await _followersService.GetFollowersCountByUser(userId);
            return followerList;
        }

    }
}
