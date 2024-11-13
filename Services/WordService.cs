using System.Net.Http.Json;
using TypicalTypist.Models;

namespace TypicalTypist.Services
{
    public class WordService(HttpClient _httpClient)
    {
        private readonly HttpClient httpClient = _httpClient;
        private readonly string url = "https://localhost:7258";

        public async Task<List<WordTestObject>> GetRandomWordsTest(int x) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/Random/{x}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetRandomCapsTest(int y) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomCaps/{y}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetRandomWordsAndNumbersTest(int z) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomNumbers/{z}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

    }


}