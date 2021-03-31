using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pdbc.Music.Common.Extensions;

namespace Pdbc.Music.Data.Migrator
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, configuration) =>
            {
                string environment = string.Empty;

                if (args.Contains("--environment") || args.Contains("-e"))
                {
                    var index = args.ToList().FindIndex(x => x.Equals("--environment") || x.Equals("-e"));
                    environment = args[index + 1];
                }

                if (string.IsNullOrWhiteSpace(environment))
                {
                    environment = Environment.GetEnvironmentVariable("SD_Environment") ?? Environments.Production;
                }

                configuration
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true);
            })
            .ConfigureServices((hostContext, services) =>
            {
                services.RegisterModule<DataModule>(hostContext.Configuration);

                services.AddHostedService<DatabaseMigrator>();
            });
    }
}
