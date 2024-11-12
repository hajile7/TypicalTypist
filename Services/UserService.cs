using System.Net.Http.Json;
using TypicalTypist.Models;

namespace TypicalTypist.Services
{
    public class UserService(HttpClient _httpClient)
    {
        private readonly HttpClient httpClient = _httpClient;
        private readonly string url = "https://localhost:7258";
        public UserDTO activeUser = new();
        public bool IsLoggedIn = false;

        public async Task<bool> PostUserAsync(PostUserDTO newUser)
        {
            var response = await httpClient.PostAsJsonAsync($"{url}/api/User", newUser);
            return response.IsSuccessStatusCode;
        }

        public async Task<UserDTO> LoginAsync(LoginModel loginModel)
        {
            var response = await httpClient.PostAsJsonAsync($"{url}/api/User/Login", loginModel);
            if(response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<UserDTO>();
                return result ?? throw new Exception("An unknown error has occured");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new Exception("User not found");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                throw new Exception("Invalid login credentials");
            }
            else
            {
                throw new Exception("An unknown error has occured");
            }
        }

        public void Logout()
        {
            if(IsLoggedIn)
            {
                activeUser = new();
                IsLoggedIn = false;
            }
        }
    }
}