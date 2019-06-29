using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Scaledriven.Api.Services
{

    public interface IGitHubApiService
    {
        Task<HttpResponseMessage> User(string username);
        Task<HttpResponseMessage> Users();
    }

    public class GithubService : IGitHubApiService
    {
        protected readonly HttpClient _httpClient;

        public GithubService(HttpClient httpClient)
        {
                httpClient.BaseAddress = new Uri("https://api.github.com/");
                httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
                httpClient.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-Sample");

            _httpClient = httpClient;
        }

        public Task<HttpResponseMessage> Users()
        {
            return _httpClient.GetAsync("/users");
        }

        public Task<HttpResponseMessage> User(string username)
        {
            return _httpClient.GetAsync($"/users/{username}");
        }

    }
}
