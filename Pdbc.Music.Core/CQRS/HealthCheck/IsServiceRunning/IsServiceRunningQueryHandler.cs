using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Pdbc.Music.Core.CQRS.HealthCheck.IsServiceRunning
{
    public class IsServiceRunningQueryHandler : IRequestHandler<IsServiceRunningQuery, IsServiceRunningViewModel>
    {
        public Task<IsServiceRunningViewModel> Handle(IsServiceRunningQuery request, CancellationToken cancellationToken)
        {
            var result = new IsServiceRunningViewModel()
            {
            };

            return Task.FromResult(result);
        }
    }
}