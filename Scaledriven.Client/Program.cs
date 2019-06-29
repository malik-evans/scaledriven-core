using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Scaledriven.Client
{

    /// <summary>
    /// Scaledriven.Client Program isolated, acting the domains entry server via "/"
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
