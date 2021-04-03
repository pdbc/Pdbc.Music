using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Common;

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

            //serviceCollection.Scan()
        }
    }

    public class GenericRequestPreProcessor<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly TextWriter _writer;

        public GenericRequestPreProcessor(TextWriter writer)
        {
            _writer = writer;
        }

        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            return _writer.WriteLineAsync("- Starting Up");
        }
    }

    public class GenericRequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    {
        private readonly TextWriter _writer;

        public GenericRequestPostProcessor(TextWriter writer)
        {
            _writer = writer;
        }

        public Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
        {
            return _writer.WriteLineAsync("- All Done");
        }
    }

    public class GenericPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly TextWriter _writer;

        public GenericPipelineBehavior(TextWriter writer)
        {
            _writer = writer;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            await _writer.WriteLineAsync("-- Handling Request");
            var response = await next();
            await _writer.WriteLineAsync("-- Finished Request");
            return response;
        }
    }
}
