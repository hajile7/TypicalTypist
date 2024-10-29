namespace TypicalTypist.Services
{
    public class UserStatService(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly string url = "https://localhost:7192/";
    }
}