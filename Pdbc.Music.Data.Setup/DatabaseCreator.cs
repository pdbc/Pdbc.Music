using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pdbc.Music.Data.Extensions;
using Pdbc.Music.Data.Seed;
using Pdbc.Music.Tests.Seed;

namespace Pdbc.Music.Data.Setup
{
    public class DatabaseCreator : IHostedService
    {
        private readonly IServiceScopeFactory scopeFactory;

        public DatabaseCreator(IServiceScopeFactory scopeFactory)
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

                    Console.WriteLine("Clearing out the database tables..");
                    var databaseService = new DatabaseService(dbContext);

                    databaseService.ClearFunctions();
                    databaseService.DropTables();
                    
                    Console.WriteLine("Migrating database to latest version");
                    database.Migrate();

                    Console.WriteLine("DbContext has been upgraded");

                    var musicSeeder = scope.ServiceProvider.GetRequiredService<IMusicDbSeedData>();
                    musicSeeder.Seed();

                    var musicTestSeeder = scope.ServiceProvider.GetRequiredService<IMusicTestsDbSeedData>();
                    musicTestSeeder.Seed();
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