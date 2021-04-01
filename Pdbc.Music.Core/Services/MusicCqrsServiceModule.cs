using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Common;

namespace Pdbc.Music.Core.Services
{
    public class MusicCqrsServiceModule : IModule
    {
        public void Register(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped<IErrorService, ErrorService>();
        }
    
    }
}
