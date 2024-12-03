namespace TypicalTypist.Models
{
    public class UserTypingTestDTO
    {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int? CharCount { get; set; }
        public int? IncorrectCount { get; set; }
        public string? Mode { get; set; }
        public decimal? Speed { get; set; }
        public decimal? Accuracy { get; set; }
    }
}