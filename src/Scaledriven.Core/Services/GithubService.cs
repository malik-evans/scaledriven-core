using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Scaledriven.Core.Services
{
    public interface IGitHubApiService
    {
        Task<HttpResponseMessage> User(string username);
        Task<HttpResponseMessage> Users();
    }

    /// <summary>
    /// Example HttpService
    /// </summary>
    public class GithubService : HttpClient, IGitHubApiService
    {
        public GithubService()
        {
                BaseAddress = new Uri("https://api.github.com/");
                DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
                DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-Sample");
        }

        public Task<HttpResponseMessage> Users() => GetAsync("/users");

        public Task<HttpResponseMessage> User(string username) => GetAsync($"/users/{username}");

    }
}
