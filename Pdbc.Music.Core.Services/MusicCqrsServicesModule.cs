using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Common;

namespace Pdbc.Music.Core.Services
{
    public class MusicCqrsServicesModule : IModule
    {
        public void Register(IServiceCollection serviceCollection, IConfiguration configuration)
        {

            //// Scan register 
            serviceCollection.Scan(scan => scan.FromAssemblyOf<MusicCqrsServicesModule>()
                .AddClasses(true)  // Get all classes implementing the IValidator<T>
                .AsMatchingInterface()
                .WithScopedLifetime()
            );


            //serviceCollection.AddScoped<IErrorMessagesCqrsService, ErrorMessagesCqrsService>();
            //serviceCollection.AddScoped<IErrorMessagesService, ErrorMessagesCqrsService>();
        }
    
    }
}
