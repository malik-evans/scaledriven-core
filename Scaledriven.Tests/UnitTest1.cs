using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Scaledriven.Api.Tests
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        public const string BaseUri = "http://localhost/";

        public UnitTest1(WebApplicationFactory<Startup> applicationFactory)
        {
            _factory = applicationFactory;
        }

        [Fact]
        public async Task Test1()
        {

            HttpClient client = _factory.CreateClient();

            HttpResponseMessage responseMessage = await client.GetAsync("/");

            Assert.Equal(BaseUri, responseMessage.RequestMessage.RequestUri.ToString());
        }


    }
}
