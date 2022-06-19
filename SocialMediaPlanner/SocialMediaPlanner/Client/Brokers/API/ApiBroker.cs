using SocialMediaPlanner.Shared.Auth.Commands.Login;
using System.Net.Http.Json;

namespace SocialMediaPlanner.Client.Brokers.API
{
    public partial class ApiBroker : IApiBroker
    {
        private readonly HttpClient _httpClient;

        public ApiBroker(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private async Task<T> GetAsync<T>(string relativeUrl) =>
            await _httpClient.GetFromJsonAsync<T>(relativeUrl);

        private async Task<HttpResponseMessage> PostAsync<T>(string relativeUrl, T content) =>
            await _httpClient.PostAsJsonAsync<T>(relativeUrl, content);

    }
}
