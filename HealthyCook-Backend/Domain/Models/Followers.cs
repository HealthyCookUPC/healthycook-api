namespace HealthyCook_Backend.Domain.Models
{
    public class Followers
    {
        public int ID { get; set; }
        public string username { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int FollowedUserID { get; set; }
        public User FollowedUser { get; set; }
    }
}
