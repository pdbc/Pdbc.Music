using System.Threading;
using NUnit.Framework;
using Pdbc.Music.Core.CQRS.Errors.List;
using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;


namespace Pdbc.Music.Core.IntegrationTests.CQRS.Errors.List
{
    public class ListErrorMessagesQueryHandlerTestFixture : MusicIntegrationTestFixture
    {
        [Test]
        public void Verify()
        {
           //var queryHandler = ServiceProvider.GetService<ListErrorMessagesQueryHandler>();
           //queryHandler.Handle(new ListErrorMessagesQuery(), (CancellationToken.None));

           var service = ServiceProvider.GetService<IErrorService>();
           service.ListErrorMessages(new ListErrorsRequest());
        }
    }
}
