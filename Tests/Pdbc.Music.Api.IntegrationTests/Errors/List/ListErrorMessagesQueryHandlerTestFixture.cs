using System;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Api.ServiceAgent;
using Pdbc.Music.Integration.Tests;
using Pdbc.Music.Integration.Tests.Errors.List;
using Pdbc.Music.UnitTests.Base;

namespace Pdbc.Music.Api.IntegrationTests.Errors.List
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