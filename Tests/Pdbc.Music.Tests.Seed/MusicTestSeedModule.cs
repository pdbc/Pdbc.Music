using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Common;

namespace Pdbc.Music.Tests.Seed
{
    public class MusicTestSeedModule : IModule
    {
        public void Register(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            // Scans all classes to register them as its matching interface.
            serviceCollection.Scan(scan => scan.FromAssemblyOf<MusicTestSeedModule>()
                .AddClasses(true)
                .AsMatchingInterface()
                .WithScopedLifetime()
            );
            
        }
    }
}