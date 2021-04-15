using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Api.ServiceAgent;
using Pdbc.Music.Integration.Tests;
using Pdbc.Music.Integration.Tests.Health.IsServiceRunning;

namespace Pdbc.Music.Api.IntegrationTests.HealthCheck.IsServiceRunning
{
    public class IsServiceRunningTestFixture : MusicIntegrationApiRequestTestFixture
    {
        protected override IIntegrationTest CreateIntegrationTest()
        {
            var service = ServiceProvider.GetService<IHealthCheckWebApiService>();
            return new IsServiceRunningTest(service, base.Context);
        }
    }
}