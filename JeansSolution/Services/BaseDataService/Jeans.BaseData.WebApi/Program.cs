using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Jeans.BaseData.WebApi
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
                    config.UseStartup<Startup>();
                });
    }
}
