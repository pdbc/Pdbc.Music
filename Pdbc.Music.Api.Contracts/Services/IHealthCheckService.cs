using Pdbc.Music.Api.Contracts.Requests.HealthCheck;
using System.Threading.Tasks;

namespace Pdbc.Music.Api.Contracts
{
    /// <summary>
    /// Service for verifying the health of the api
    /// </summary>
    public interface IHealthCheckService
    {

        /// <summary>
        /// Verifies if the service is running correctly
        /// </summary>
        /// <param name="request">The messageRequest.</param>
        /// <returns></returns>
        Task<IsServiceRunningResponse> IsServiceRunning(IsServiceRunningRequest request);

    }
}
