using System.IO;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scaledriven.Areas.Association.config;
using Scaledriven.Areas.Association.Database;
using Scaledriven.Areas.Association.Models;
using Scaledriven.Areas.Association.Service;
using Scaledriven.Services;

namespace Scaledriven.Areas.Association
{
    public static class AssociationServiceExtensions
    {

        /// child namespace to the content root
        public readonly static string BasePath = "Association";

        public readonly static IConfiguration Configuration = new ConfigurationBuilder()
            /**
             * Only require configuration by extension
             * $"/Areas/{BasePath}" relative from the program root.
             * Represents the areas position as a namespace
             *
             * Important!
             * For instance If this containing folder - "Association"
             * is moved up a directory, the value would be $"/{BasePath}"
             * instead of $"/Areas/{BasePath}"
             */
            .SetBasePath(Directory.GetCurrentDirectory() + $"/Areas/{BasePath}")
            .AddJsonFile("appsettings.json")
            .Build();

        public static IServiceCollection AddAssociationContext(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<AssociationDbContext>();

            // class presentation of static view data
            serviceCollection.Configure<HomeViewData>(Configuration.GetSection("Pages/Home"));
            serviceCollection.AddTransient<IFactory<Person>, PersonFactory>();
            return serviceCollection;
        }

    }
}
