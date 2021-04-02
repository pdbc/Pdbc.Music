using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Pdbc.Music.Common.Extensions;
using Pdbc.Music.Core.Services;
using Pdbc.Music.Data;

namespace Pdbc.Music.Core.IntegrationTests
{
    public class MusicIntegrationTestBootstrap
    {
        public static void BootstrapContainer(IServiceCollection services, 
                                              IConfiguration configuration)
        {
            services.RegisterModule<MusicCoreModule>(configuration);
            services.RegisterModule<MusicCqrsServiceModule>(configuration);
            services.RegisterModule<MusicDataModule>(configuration);

            //services.RegisterModule<MusicDataModule>(configuration);
            //services.RegisterModule<InfrastructureModule>(configuration);
            //services.RegisterModule<FunctionalityCoreModule>(configuration);
            //services.RegisterModule<CiaModule>(configuration);
            //services.RegisterModule<FunctionalityDomainConfigurationModule>(configuration);

            //services.RegisterModule<ServicesModule>(configuration);
            //services.RegisterModule<TokenExchangeModule>(configuration);
        }
    }
}
