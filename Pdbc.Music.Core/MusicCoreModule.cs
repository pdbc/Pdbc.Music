using System;
using System.IO;
using FluentValidation;
using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Common;
using Pdbc.Music.Common.Validation;
using Pdbc.Music.Core.CQRS;

namespace Pdbc.Music.Core
{
    public class MusicCoreModule : IModule
    {
        public void Register(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddMediatR(typeof(MusicCoreModule));

            serviceCollection.AddScoped(typeof(IPipelineBehavior<,>), typeof(GenericPipelineBehavior<,>));
            serviceCollection.AddScoped(typeof(IRequestPreProcessor<>), typeof(GenericRequestPreProcessor<>));
            serviceCollection.AddScoped(typeof(IRequestPostProcessor<,>), typeof(GenericRequestPostProcessor<,>));

            serviceCollection.AddScoped<ValidationBag>();

            //// Scan register 
            serviceCollection.Scan(scan => scan.FromAssemblyOf<MusicCoreModule>()
                .AddClasses(classes => classes.AssignableTo(typeof(IValidator<>)).Where(_ => !_.IsGenericType))  // Get all classes implementing the IValidator<T>
                .AsImplementedInterfaces()
                .WithScopedLifetime()
            );
        }
    }
}
