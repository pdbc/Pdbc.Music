using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Core.Services;
using Pdbc.Music.Integration.Tests;
using Pdbc.Music.Integration.Tests.ErrorMessages.Get;

namespace Pdbc.Music.Core.IntegrationTests.CQRS.ErrorMessages.Get
{
    public class GetErrorMessageWithoutLanguageTestFixture : MusicIntegrationCqrsRequestTestFixture
    {
        protected override IIntegrationTest CreateIntegrationTest()
        {
            var service = ServiceProvider.GetService<IErrorMessagesCqrsService>();
            return new GetErrorMessageWithoutLanguageTest(service, base.Context);
        }
    }
}