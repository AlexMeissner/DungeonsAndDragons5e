using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace RestAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Utility.Logger.SetLogLevel(Utility.Logger.LogLevel.Trace);
            CreateClientHostBuilder(args).Build().RunAsync();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static IHostBuilder CreateClientHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(builder =>
                {
                    builder.UseStartup<ClientHostStartup>();
                    builder.UseUrls("http://localhost:80/");
                    builder.UseContentRoot(@"W:\Projects\Coding\DungeonsAndDragons5e\dnd-client\dist");
                    builder.UseWebRoot("dnd-client");
                });
    }
}