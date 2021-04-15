using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Common;
using System;

namespace Pdbc.Music.Api.ServiceAgent
{
    public class MusicServiceAgentModule : IModule
    {
        public void Register(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddSingleton<IMusicApiServiceAgentConfiguration, MusicApiServiceAgentConfiguration>();

            serviceCollection.AddScoped<IErrorMessagesWebApiService, ErrorMessagesWebApiService>();
            serviceCollection.AddScoped<IHealthCheckWebApiService, HealthCheckWebApiService>();

            var config = new MusicApiServiceAgentConfiguration(configuration);
            serviceCollection.AddHttpClient(config.Name, c =>
            {
                c.BaseAddress = new Uri(config.BaseUrl);

                // Github API versioning
                //c.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");

                // Github requires a user-agent
                //c.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-Sample");
            });
        }

    }
}
