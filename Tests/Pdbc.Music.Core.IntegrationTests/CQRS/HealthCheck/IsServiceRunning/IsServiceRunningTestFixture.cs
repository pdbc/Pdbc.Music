using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Core.Services;
using Pdbc.Music.Integration.Tests;
using Pdbc.Music.Integration.Tests.Health.IsServiceRunning;

namespace Pdbc.Music.Core.IntegrationTests.CQRS.HealthCheck.IsServiceRunning
{
    public class IsServiceRunningTestFixture : MusicIntegrationCqrsRequestTestFixture
    {
        protected override IIntegrationTest CreateIntegrationTest()
        {
            var service = ServiceProvider.GetRequiredService<IHealthCheckCqrsService>();
            return new IsServiceRunningTest(service, base.Context);
        }
    }
}