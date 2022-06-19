using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using SocialMediaPlanner.Client.Brokers.API;
using SocialMediaPlanner.Client.Providers;
using SocialMediaPlanner.Shared.Auth.Commands.Login;

namespace SocialMediaPlanner.Client.Service.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IApiBroker broker;
        private readonly ILocalStorageService localStorage;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public AuthenticationService(IApiBroker broker, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider)
        {
            this.broker = broker;
            this.localStorage = localStorage;
            this.authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<bool> AuthenticateAsync(LoginUserDto loginModel)
        {
            var response = await broker.LoginAsync(loginModel);

            await localStorage.SetItemAsync("accessToken", response.Token);

            await((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedIn();

            return true;
        }
        public async Task Logout()
        {
            await ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedOut();
        }
    }
}
