namespace TypicalTypist.Models
{
    public class UserKeyStatFull
    {
        public string Key { get; set; } = string.Empty;
        public int Frequency { get; set; }
        public int CorrectCount { get; set; }
        public decimal TotalSpeed { get; set; }
        public int BigraphCount { get; set; } 

    }
}