using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleBooksStore.Models;
using LittleBooksStore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LittleBooksStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc( option => option.EnableEndpointRouting = false);

            //adding the services for the aplication read the DI in Home Controller Constror
            services.AddSingleton<IRepository<Book>, MockBooksRepository>();
            services.AddTransient<IRepository<Carousel>, MockCarouselRepository>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
         

            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
            app.UseMvc(ConfigurationRoutes);
            app.UseStaticFiles() ;
        }

        private static void ConfigurationRoutes(IRouteBuilder route)
        {
            route.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
