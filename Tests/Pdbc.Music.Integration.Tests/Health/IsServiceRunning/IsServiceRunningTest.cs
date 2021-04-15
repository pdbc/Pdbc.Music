using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.HealthCheck;
using Pdbc.Music.Data;
using Pdbc.Music.UnitTests.Base;

namespace Pdbc.Music.Integration.Tests.Health.IsServiceRunning
{
    public class IsServiceRunningTest : HealthCheckServiceTest<IsServiceRunningResponse>
    {
        public IsServiceRunningTest(IHealthCheckService service, MusicDbContext dbContext)
            : base(service, dbContext)
        {
        }

        private IsServiceRunningRequest _request;

        public override void Setup()
        {
            _request = new IsServiceRunningRequest()
            {

            };
        }

        public override void Cleanup()
        {
        }

        public override IsServiceRunningResponse PerformAction()
        {
            return Service.IsServiceRunning(_request)
                        .GetAwaiter()
                        .GetResult();
        }

        public override void VerifyResponse(IsServiceRunningResponse response)
        {
            response.ShouldNotBeNull();
            response.Notifications.HasErrors().ShouldBeFalse();
        }
    }
}
