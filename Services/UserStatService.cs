using System.Net.Http.Json;
using TypicalTypist.Models;

namespace TypicalTypist.Services
{
    public class UserStatService(HttpClient _httpClient)
    {
        private readonly HttpClient httpClient = _httpClient;
        private readonly string url = "https://localhost:7258";

        public async Task<bool> PostTest(UserTypingTestDTO userTest)
        {
            var response = await httpClient.PostAsJsonAsync($"{url}/api/UserStats/tests", userTest);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> PostBigraphStats(List<UserBigraphStatDTO> bigraphStats)
        {
            var response = await httpClient.PostAsJsonAsync($"{url}/api/UserStats/bigraphs", bigraphStats);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> PostKeyStats(List<UserKeyStatDTO> keyStats)
        {
            var response = await httpClient.PostAsJsonAsync($"{url}/api/UserStats/keys", keyStats);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> PostStats(UserStatDTO userStats)
        {
            var response = await httpClient.PostAsJsonAsync($"{url}/api/UserStats/stats", userStats);
            return response.IsSuccessStatusCode;
        }
        public async Task<UserStats> GetStats(int userId)
        {
            var response = await httpClient.GetFromJsonAsync<UserStats>($"{url}/api/UserStats/UserStats?userId={userId}");
            if(response != null)
            {
                var result = response;
                return result ?? throw new Exception("An unknown error has occured");
            }
            else
            {
                throw new Exception("An unknown error has occured");
            }
        }
    }
}