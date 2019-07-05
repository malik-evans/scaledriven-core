using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Scaledriven.Client
{

    /// <summary>
    /// Scaledriven.Client Program isolated, acting the domains entry server via "/"
    /// </summary>
    public class Program
    {
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .UseUrls("http://*:3000;http://localhosts:3001;")
                .Build()
                .Run();

        }
    }
}
