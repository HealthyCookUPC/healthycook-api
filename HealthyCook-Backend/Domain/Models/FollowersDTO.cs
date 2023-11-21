namespace HealthyCook_Backend.Domain.Models
{
    public class FollowersDTO
    {
        public string FollowerUsername { get; set; }
        public int UserID { get; set; }
        public string FollowedUsername { get; set; }
        public int FollowedUserID { get; set; }
    }
}
