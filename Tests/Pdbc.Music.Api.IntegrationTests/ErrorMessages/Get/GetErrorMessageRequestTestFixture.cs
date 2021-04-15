using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.ServiceAgent;
using Pdbc.Music.Integration.Tests;
using Pdbc.Music.Integration.Tests.Errors.Get;

namespace Pdbc.Music.Api.IntegrationTests.Errors.Get
{
    [TestFixture]
    public class GetErrorMessageRequestTestFixture : MusicIntegrationApiRequestTestFixture
    {
        protected override IIntegrationTest CreateIntegrationTest()
        {
            var service = ServiceProvider.GetRequiredService<IErrorMessagesWebApiService>();
            return new GetErrorMessageTest(service, base.Context);
        }


    }
}
