namespace TypicalTypist.Models
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public DateTime Joined { get; set; }
        public string UserName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}