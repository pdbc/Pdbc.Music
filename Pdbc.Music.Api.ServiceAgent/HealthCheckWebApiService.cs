using Pdbc.Music.Api.Contracts.Requests.HealthCheck;
using Pdbc.Music.Api.ServiceAgent.Extensions;
using System.Net.Http;
using System.Threading.Tasks;

namespace Pdbc.Music.Api.ServiceAgent
{
    public class HealthCheckWebApiService : IHealthCheckWebApiService
    {
        private string _route = "HealthCheck";
        private readonly WebApiClientProxy _proxy;

        public HealthCheckWebApiService(IHttpClientFactory clientFactory, IMusicApiServiceAgentConfiguration configuration)
        {
            _proxy = new WebApiClientProxy(clientFactory, configuration.Name);
        }


        public async Task<IsServiceRunningResponse> IsServiceRunning(IsServiceRunningRequest request)
        {
            var response = await _proxy.CallAsync(c => c.GetAsync($"{_route}/IsServiceRunning"));
            return await response.Deserialize<IsServiceRunningResponse>();

        }
    }
}
