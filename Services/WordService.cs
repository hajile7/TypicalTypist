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

        public async Task<List<WordTestObject>> GetRandomWordsAndNumsTest(int y) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomNums/{y}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetRandomWordsAndSymbolsTest(int z) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomSymbols/{z}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetRandomWordsNumsAndSymbolsTest(int ax) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomNumsAndSymbols/{ax}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetRandomCapsTest(int ay) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomCaps/{ay}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetRandomCapsAndNumsTest(int az) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomCapsNums/{az}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetRandomCapsAndSymbolsTest(int bx) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomCapsSymbols/{bx}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetRandomCapsNumsAndSymbolsTest(int by) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/RandomCapsNumsAndSymbols/{by}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

        public async Task<List<WordTestObject>> GetChaoticTest(int bz) {
            List<WordTestObject> result = await httpClient.GetFromJsonAsync<List<WordTestObject>>($"{url}/api/Words/Chaotic/{bz}") 
            ?? throw new InvalidOperationException("The response from the API was null.");
            return result;
        }

    }


}