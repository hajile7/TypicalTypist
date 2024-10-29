namespace TypicalTypist.Models
{
    public class UserBigraphStat
    {
        public int? UserId { get; set; }
        public string StartingKey { get; set; } = null!;
        public string Bigraph { get; set; } = null!;
        public int? TotalTyped { get; set; }
        public decimal? Accuracy { get; set; }
        public decimal? Speed { get; set; }
    }
}