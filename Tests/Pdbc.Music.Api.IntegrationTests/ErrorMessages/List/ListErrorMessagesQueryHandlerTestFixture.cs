using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Api.ServiceAgent;
using Pdbc.Music.Integration.Tests;
using Pdbc.Music.Integration.Tests.Errors.List;

namespace Pdbc.Music.Api.IntegrationTests.ErrorMessages.List
{
    public class ListErrorMessagesQueryHandlerTestFixture : MusicIntegrationApiRequestTestFixture
    {
        protected override IIntegrationTest CreateIntegrationTest()
        {
            var service = ServiceProvider.GetRequiredService<IErrorMessagesWebApiService>();
            return new ListErrorMessagesTest(service, base.Context);
        }
    }
}