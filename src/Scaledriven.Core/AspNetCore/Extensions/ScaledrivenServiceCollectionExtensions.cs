using Microsoft.Extensions.DependencyInjection;
using Scaledriven.Core.AspNetCore.Design;
using Scaledriven.Core.DataAccess;
using Scaledriven.Core.DataAccess.Models;

namespace Scaledriven.Core.AspNetCore.Extensions
{
    public static class ScaledrivenServiceCollectionExtensions
    {
        public static IServiceCollection AddScaledriven(this IServiceCollection services)
        {
            services.AddDbContext<CoreDbContext>();
            services.AddScoped<IRepository<User>, Repository<User>>();
            services.AddScoped<ModelActionFilter>();
            services.AddMvc();
            return services;
        }
    }
}
