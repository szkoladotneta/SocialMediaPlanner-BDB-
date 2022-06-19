using SocialMediaPlanner.Shared.Auth.Commands.Login;
using SocialMediaPlanner.Shared.Auth.Commands.Register;

namespace SocialMediaPlanner.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<AuthResponse> LoginAsync(LoginUserDto userDto);
        Task RegisterAsync(UserDto user);
    }
}
