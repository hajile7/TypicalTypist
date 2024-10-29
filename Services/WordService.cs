using System.Net.Http.Json;
using TypicalTypist.Models;

namespace TypicalTypist.Services
{
    public class WordService(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly string url = "https://localhost:7192/";

        public async Task<List<WordTestObject>> GetRandomTest() {
            List<WordTestObject> result = await _httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}api/Words/Random") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

    }


}