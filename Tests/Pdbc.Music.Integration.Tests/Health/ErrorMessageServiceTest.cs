using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests;
using Pdbc.Music.Data;

namespace Pdbc.Music.Integration.Tests.Health
{
    public abstract class HealthCheckServiceTest<Result> : IntegrationTest<Result> where Result : MusicResponse
    {
        protected IHealthCheckService Service;

        protected HealthCheckServiceTest(IHealthCheckService service, MusicDbContext dbContext) : base(dbContext)
        {
            Service = service;
        }
    }
}
