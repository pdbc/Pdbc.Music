using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Common;
using Pdbc.Music.Data.Repositories;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data
{
    public class MusicDataModule : IModule
    {
        public void Register(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var settings = new DataSettings(configuration);
            serviceCollection.AddSingleton(settings);

            serviceCollection.AddDbContext<MusicDbContext>(options => options.UseSqlServer(
                settings.DbConnectionString, builder =>
                {
                    builder.EnableRetryOnFailure(
                        settings.SqlServerMaxRetryCount,
                        TimeSpan.FromMilliseconds(settings.SqlServerMaxDelay),
                        new List<int>()
                    );

                    builder.MigrationsHistoryTable(DbConstants.MigrationsTableName, DbConstants.DefaultSchemaName);
                }));


            serviceCollection.AddOptions(); //Is necessary in order for IOptions<T> to work


            serviceCollection.AddScoped<IArtistRepository, ArtistRepository>();
            serviceCollection.AddScoped<IEntityRepository<Artist>, ArtistRepository>();
            serviceCollection.AddScoped<IGenreRepository, GenreRepository>();
            serviceCollection.AddScoped<IEntityRepository<Genre>, GenreRepository>();



            //serviceCollection.Scan(scan => scan.FromAssemblyOf<MusicDataModule>()
            //    .AddClasses(true)
            //    .AsMatchingInterface()
            //    .WithScopedLifetime()
            //);
        }
    }
}