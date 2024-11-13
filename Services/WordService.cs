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

        public async Task<List<WordTestObject>> GetRandomWordsAndNumsTest(int z) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomNums/{z}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetRandomWordsAndSymbolsTest(int ax) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomSymbols/{ax}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetRandomCapsAndNumsTest(int ay) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomCapsNums/{ay}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetRandomCapsAndSymbolsTest(int az) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomCapsSymbols/{az}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetRandomCapsNumsAndSymbolsTest(int bx) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomCapsNumsAndSymbols/{bx}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetChaoticTest(int by) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/Chaotic/{by}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

    }


}