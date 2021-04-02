using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pdbc.Music.Data.Extensions;

namespace Pdbc.Music.Data.Migrator
{
    public class DatabaseMigrator : IHostedService
    {
        private readonly IServiceScopeFactory scopeFactory;

        public DatabaseMigrator(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                try
                {
                    Console.WriteLine("Creating database context...");
                    var dbContext = scope.ServiceProvider.GetRequiredService<MusicDbContext>();
                    var database = dbContext.Database;

                    Console.WriteLine("Migrating database...");
                    database.Migrate();
                    dbContext.EnsureSeedData();

                    Console.WriteLine("DbContext has been upgraded");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception occurred while upgrading DbContext. Details : {0}", e);
                    throw;
                }
            }

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}