namespace HealthyCook_Backend.Domain.Models
{
    public class UpdateUserDto
    {
        public int UserID { get; set; }  
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
