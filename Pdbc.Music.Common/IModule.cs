using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Pdbc.Music.Common
{
    public interface IModule
    {
        void Register(IServiceCollection serviceCollection, IConfiguration configuration);
    }
}