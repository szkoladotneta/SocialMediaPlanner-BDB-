using SocialMediaPlanner.Shared.Auth.Commands.Login;
using SocialMediaPlanner.Shared.Auth.Commands.Register;
using System.Text.Json;

namespace SocialMediaPlanner.Client.Brokers.API
{
    public partial class ApiBroker
    {
        private const string AuthRelativeUrl = "api/auth";
        public async Task<AuthResponse> LoginAsync(LoginUserDto userDto)
        {
            var response = await this.PostAsync<LoginUserDto>(AuthRelativeUrl + "/login", userDto);
            var str = await response.Content.ReadAsStringAsync();

            var auth = JsonSerializer.Deserialize<AuthResponse>(str, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return auth;
        }
            

        public async Task RegisterAsync(UserDto user) =>
            await this.PostAsync(AuthRelativeUrl + "/register", user);
    }
}
