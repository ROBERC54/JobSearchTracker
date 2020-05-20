using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using JobSearchTrackerAPI.Data;
using JobSearchTrackerAPI.Models;
using Microsoft.Extensions.DependencyInjection;


namespace JobSearchTrackerAPI
{
    public class Program
    {/*public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }*/
        //Remember: Force the app to initialize (call the methods in the Startup class) so the seed method runs. To force initialization, IIS Express must be stopped and restarted. You can do this with any of the following approaches:
            //Right click the IIS Express system tray icon in the notification area and tap Exit or Stop Site
            //If you were running VS in non-debug mode, press F5 to run in debug mode
            //If you were running VS in debug mode, stop the debugger and press F5
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
