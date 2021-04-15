using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Core.Services;
using Pdbc.Music.Integration.Tests;
using Pdbc.Music.Integration.Tests.Errors.Get;

namespace Pdbc.Music.Core.IntegrationTests.CQRS.ErrorMessages.Get
{
    public class GetErrorMessageTestFixture : MusicIntegrationCqrsRequestTestFixture
    {
        protected override IIntegrationTest CreateIntegrationTest()
        {
            var service = ServiceProvider.GetRequiredService<IErrorMessagesCqrsService>();
            return new GetErrorMessageTest(service, base.Context);
        }
    }
}
