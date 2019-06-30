using System;
using System.IO;

using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.DependencyInjection;
using Scaledriven.Api.Areas.App.Database;
using Scaledriven.Api.Areas.App.Services;
using Scaledriven.Api.Helpers;
using Scaledriven.Api.Areas.App.Shared;
using Scaledriven.Core.AspNetCore.Extensions;
using Swashbuckle.AspNetCore.Swagger;

namespace Scaledriven.Api
{
    public class Startup
    {
        public readonly IConfigurationRoot Configuration;

        public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // settings
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            services.AddScaledriven();

            // configure mvc & services
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // http services
            services.AddHttpClient<IGitHubApiService, GithubService>();

            // middleware & filters
            services.AddScoped<ModelActionFilter>();

            // db context
            services.AddDbContext<ApplicationDbContext>();


            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new Info
                    {
                        Title = Configuration.GetSection("Api:Title").Value,
                        Version = Configuration.GetSection("Api:Version").Value
                    });

                    // Set the comments path for the Swagger JSON and UI.
                    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    c.IncludeXmlComments(xmlPath);
                });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors( x => x
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "swagger";
            });

            app.UseMvc(routes =>
                routes.MapRoute( name: "areaRoutes", template: "{area:exists=App/Info}/{controller=Home}/{action=Index}/{id?}"));

            app.Run(context =>
            {
                context.Response.Redirect("swagger");
                return Task.CompletedTask;
            });


        }
    }
}
