using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Scaledriven.Api
{
    public class Program
    {

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .UseUrls("http://*:5000;http://localhosts:5001;")
                .Build()
                .Run();

        }
    }
}
