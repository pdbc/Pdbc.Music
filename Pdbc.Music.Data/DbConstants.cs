namespace Pdbc.Music.Data
{
    public static class DbConstants
    {
        public const string DefaultSchemaName = "dbo";

        public const string MigrationsTableName = "__MigrationsHistory";

        public const string ConnectionStringName = "MusicDbContext";
        public const string AdminConnectionStringName = "AdminMusicDbContext";


        public const string MaxRetryCountValue = "sqlServer:maxRetryCount";
        public const string MaxDelayValue = "sqlServer:maxDelay";
        public const string UseAdminConnectionString = "sqlServer:useAdminConnectionString";
        
        public const string MigrationsAssembly = "Pdbc.Music.Data";
    }
}