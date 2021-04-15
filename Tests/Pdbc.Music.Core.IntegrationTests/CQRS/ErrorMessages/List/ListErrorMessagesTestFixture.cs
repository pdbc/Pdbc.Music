using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Core.Services;
using Pdbc.Music.Integration.Tests;
using Pdbc.Music.Integration.Tests.Errors.List;

namespace Pdbc.Music.Core.IntegrationTests.CQRS.ErrorMessages.List
{
    public class ListErrorMessagesTestFixture : MusicIntegrationCqrsRequestTestFixture
    {
        protected override IIntegrationTest CreateIntegrationTest()
        {
            var service = ServiceProvider.GetRequiredService<IErrorMessagesCqrsService>();
            return new ListErrorMessagesTest(service, base.Context);
        }
    }
}