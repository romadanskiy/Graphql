using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebAppDocker.SchemaStitching;
using WebAppDocker.SchemaStitching.Query;

namespace WebAppDocker
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            

            services.AddHttpClient(WellKnownSchemaNames.Phones,
                c => c.BaseAddress = new Uri("http://ch/graphql"));
            services.AddHttpClient(WellKnownSchemaNames.Devices,
                c => c.BaseAddress = new Uri("http://hc/graphql"));

            services.AddGraphQLServer()
                .AddQueryType<QueryType>()
                .AddRemoteSchema(WellKnownSchemaNames.Phones, ignoreRootTypes: true)
                .AddRemoteSchema(WellKnownSchemaNames.Devices, ignoreRootTypes: true);

            // .AddTypeExtensionsFromFile("./Stitching.graphql");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting()
                .UseEndpoints(endpoints => { endpoints.MapGraphQL(); });
            app.UseRouting()
                .UseEndpoints(endpoints => { endpoints.MapRazorPages(); });

            app.UseAuthorization();
        }
    }
}