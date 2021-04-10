using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Integration.Tests;
using Pdbc.Music.Integration.Tests.Errors.Get;

namespace Pdbc.Music.Api.IntegrationTests.Errors.Get
{
    public class GetErrorMessageRequestTestFixture : MusicIntegrationApiRequestTestFixture
    {
        protected override IIntegrationTest CreateIntegrationTest()
        {
            var service = ServiceProvider.GetService<IErrorMessagesService>();
            return new GetErrorMessageTest(service, base.Context);
        }


    }
}
