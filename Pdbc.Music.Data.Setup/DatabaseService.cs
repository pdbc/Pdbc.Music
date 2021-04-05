using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pdbc.Music.Common.Extensions;

namespace Pdbc.Music.Data.Setup
{
    public class DatabaseService
    {
        private readonly MusicDbContext _context;

        private readonly IList<String> Tables = new List<string>()
        {
            "__MigrationsHistory"
        };

        private readonly IList<String> Functions = new List<string>()
        {
        };
        public DatabaseService(MusicDbContext context)
        {
            _context = context;

            var model = _context.Model.GetRelationalModel();
            var functions = model.Functions; 
            foreach (var function in functions)
            {
                Functions.Add(function.Name);
            }

            var tables = _context.Model.GetRelationalModel().Tables; //.Model.;
            foreach (var table in tables)
            {
                Tables.Add(table.Name);
            }
        }

        public void DropTables()
        {
            for (var i = 0; i < 6; i++)
            {
                InnerDropTables();
            }
        }

        public void ClearFunctions()
        {
            foreach (var function in Functions)
            {
                Action action = () => _context.Database.ExecuteSqlRaw($"DROP FUNCTION [dbo].[{function}]");
                action.IgnoreException();
            }
        }

        public void InnerDropTables()
        {

            foreach (var table in Tables)
            {
                Action action = () => _context.Database.ExecuteSqlRaw($"DROP TABLE [dbo].[{table}]");
                action.IgnoreException();
            }
        }
    }


    //private static void SetupDatabase()
    //{
    //// Clear the tables
    //Unittests.Helpers.SetupDatabase.ClearDatabaseTables(_configuration);

    //// Migrate the databse
    //var connectionProvider = new IdentityStoreDbContextConnectionStringProvider(new IdentityStoreConfiguration(_configuration), _configuration);
    //var connectionString = connectionProvider.GetConnectionString();
    //var migrationConfiguration = new Configuration()
    //{
    //    TargetDatabase = new DbConnectionInfo(connectionString, ProviderInvariantName)
    //};
    //var dbMigrator = new DbMigrator(migrationConfiguration, new MigrationDbContext(connectionString));
    ////dbMigrator.Update("v122");
    //dbMigrator.Update();

    //// Seed the data
    //Unittests.Helpers.SetupDatabase.Seed(_configuration);

    ////Unittests.Helpers.SetupDatabase.Run(_configuration);

    //}
}
