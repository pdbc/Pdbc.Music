using AutoMapper.Configuration.Annotations;
using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.ServiceAgent;
using Pdbc.Music.Integration.Tests;
using Pdbc.Music.Integration.Tests.ErrorMessages.Get;
using Pdbc.Music.Integration.Tests.Errors.Get;

namespace Pdbc.Music.Api.IntegrationTests.Errors.Get
{
    public class GetErrorMessageWithoutLanguageTestFixture : MusicIntegrationApiRequestTestFixture
    {
        protected override IIntegrationTest CreateIntegrationTest()
        {
            var service = ServiceProvider.GetRequiredService<IErrorMessagesWebApiService>();
            return new GetErrorMessageWithoutLanguageTest(service, base.Context);
        }
    }
}