namespace TypicalTypist.Models
{
    public class UserStatDTO
    {
        public int? UserId { get; set; }
        public int? CharsTyped { get; set; }
        public int? TimeTyped { get; set; }
        public decimal? WPM { get; set; }
        public decimal? Accuracy { get; set; }
    }
}