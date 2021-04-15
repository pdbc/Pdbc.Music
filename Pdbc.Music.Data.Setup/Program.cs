using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pdbc.Music.Common.Extensions;
using Pdbc.Music.Tests.Seed;

namespace Pdbc.Music.Data.Setup
{
    class Program
    {
        private static IConfiguration _configuration;

        static void Main(string[] args)
        {
            var hostBuilder = CreateHostBuilder(args);
            var host = hostBuilder.Build();
            host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, configuration) =>
            {
                configuration
                     .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            })
            .ConfigureServices((hostContext, services) =>
            {
                services.RegisterModule<MusicDataModule>(hostContext.Configuration);
                services.RegisterModule<MusicTestSeedModule>(hostContext.Configuration);

                services.AddScoped<DatabaseService>();
                services.AddHostedService<DatabaseCreator>();
            });

    }
}
