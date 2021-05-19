using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

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
                    config.UseUrls("http://*:10000")
                          .UseStartup<Startup>();
                });
    }
}
