using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Common.Extensions;
using Pdbc.Music.Core.Mappings;
using Pdbc.Music.Core.Services;
using Pdbc.Music.Data;

namespace Pdbc.Music.Core.IntegrationTests
{
    public class MusicIntegrationTestBootstrap
    {
        public static void BootstrapContainer(IServiceCollection services, 
                                              IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(RequestToCqrsMappings),
                                   typeof(ArtistDtoMappings));


            services.RegisterModule<MusicCoreModule>(configuration);
            services.RegisterModule<MusicCqrsServicesModule>(configuration);
            services.RegisterModule<MusicDataModule>(configuration);
        }
    }
}
