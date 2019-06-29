using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Tests
{
    public class EndPointTest : IClassFixture<WebApplicationFactory<Scaledriven.Startup>>
    {
        private readonly WebApplicationFactory<Scaledriven.Startup> _factory;
        public const string BaseUri = "http://localhost/";

        public EndPointTest(WebApplicationFactory<Scaledriven.Startup> applicationFactory)
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
