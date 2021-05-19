using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Ocelot.DependencyInjection;

namespace Jeans.Ocelot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(config =>
                {
                    config.ConfigureAppConfiguration((hostingContext, builder) =>
                    {
                        builder.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                               .AddJsonFile("ocelot.json", false, true);
                    });

                    config.UseUrls("http://*:10000");
                    config.UseStartup<Startup>();
                });
    }
}
