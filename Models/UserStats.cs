namespace TypicalTypist.Models
{
    public class UserStats
    {
        public int? UserId { get; set; }
        public int? CharsTyped { get; set; }
        public int? TimeTyped { get; set; }
        public decimal? TopWpm { get; set; }
        public decimal? Wpm { get; set; }
        public decimal? TopCpm { get; set; }
        public decimal? Cpm { get; set; }
        public decimal? TopAccuracy { get; set; }
        public decimal? Accuracy { get; set; }
    }
}