namespace TypicalTypist.Models
{
    public class UserBigraphStatDTO
    {
        public int? UserId { get; set; }
        public string Bigraph { get; set; } = null!;
        public decimal? Speed { get; set; }
        public int CorrCount { get; set; }
        public decimal? Accuracy { get; set; }
        public int? Quantity { get; set; }
    }
}