using System.Threading.Tasks;
using AutoMapper;
using MediatR;

using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.HealthCheck;
using Pdbc.Music.Common.Validation;

using Pdbc.Music.Core.CQRS.HealthCheck.IsServiceRunning;

namespace Pdbc.Music.Core.Services
{
    public class HealthCheckCqrsService : CqrsService, IHealthCheckCqrsService, IHealthCheckService
    {
        public HealthCheckCqrsService(IMediator mediator, IMapper mapper, ValidationBag validationBag) 
            : base(mediator, mapper, validationBag)
        {
        }

        public async Task<IsServiceRunningResponse> IsServiceRunning(IsServiceRunningRequest request)
        {
            return await Query<IsServiceRunningRequest, IsServiceRunningQuery,
                               IsServiceRunningViewModel, IsServiceRunningResponse>(request);
        }
    }
}
