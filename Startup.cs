using System;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;

namespace HelloMvc
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.Run(async (context) => 
            {
                Console.WriteLine("Request for " + context.Request.Path);
                await context.Response.WriteAsync("Hello World!");
            });
//              loggerFactory.AddConsole();
//              
//              app.UseErrorPage();
//  
//              app.UseMvcWithDefaultRoute();
//  
//              app.UseWelcomePage();
        }
    }
}