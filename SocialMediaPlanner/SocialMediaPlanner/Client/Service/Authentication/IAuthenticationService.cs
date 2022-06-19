using SocialMediaPlanner.Shared.Auth.Commands.Login;

namespace SocialMediaPlanner.Client.Service.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);
        public Task Logout();
    }
}
