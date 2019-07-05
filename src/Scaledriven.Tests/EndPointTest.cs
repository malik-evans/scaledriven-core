using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Scaledriven.Tests
{
    public class EndPointTest : IClassFixture<WebApplicationFactory<Scaledriven.Api.Startup>>
    {
        private readonly WebApplicationFactory<Scaledriven.Api.Startup> _factory;
        public const string BaseUri = "http://localhost/";

        public EndPointTest(WebApplicationFactory<Scaledriven.Api.Startup> applicationFactory)
        {
            _factory = applicationFactory;
        }


        [Fact]
        public async Task Returns_SpaDocument()
        {
            HttpClient client = _factory.CreateClient();

            HttpResponseMessage responseMessage = await client.GetAsync("/");

            Assert.NotEmpty(responseMessage.Content.ToString());
        }
    }
}
