using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Heron
{
    public class Startup
    {
        // Responsibilities of this class: 
        // 1. Defining the request pipelines 
        // 2. Configuring all the services that we need through out the application

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // This method registers services for your application.  
            // ASP.NET Core uses dependency injection (Constructor Injection).  
            // Services are objects that have certain functionality for other parts of the application

            services.AddMvc();
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Request pipelines is set up. Middle ware component will handle http requests.
            // The components can intercept or handle(respond) HTTP requests.

            // By default we dont get any feedback when something goes wrong. 
            // It makes sure that when something goes wrong in application we get an exception. This should only be used when we are developing the application
            app.UseDeveloperExceptionPage();
            // This middle ware component will show information about the status of the request 
            app.UseStatusCodePages();
            // Support for static files. Searches the wwwroot folder and returns the static file from there. 
            app.UseStaticFiles();
            // MVC middle ware component: 
            app.UseMvcWithDefaultRoute();

            /* This was the default pipeline
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/
        }
    }
}
