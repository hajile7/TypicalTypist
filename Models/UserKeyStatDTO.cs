namespace TypicalTypist.Models
{
    public class UserKeyStatDTO
    {
        public int? UserId { get; set; }
        public string Key { get; set; } = null!;
        public int? TotalTyped { get; set; }
        public decimal? Accuracy { get; set; }
        public decimal? Speed { get; set; }
    }
}