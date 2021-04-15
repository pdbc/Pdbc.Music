using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.HealthCheck;
using Pdbc.Music.Core.Services;

namespace Pdbc.Music.Api.Common.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : MusicBaseController
    {
        private readonly IHealthCheckCqrsService _healthCheckService;

        public HealthCheckController(IHealthCheckCqrsService healthCheckService)
        {
            _healthCheckService = healthCheckService;
        }
        [HttpGet("IsServiceRunning", Name = nameof(IsRunning))] 
        
        [ProducesResponseType(typeof(IsServiceRunningResponse), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IsServiceRunningResponse>> IsRunning([FromRoute] IsServiceRunningRequest request)
        {
            var response = await _healthCheckService.IsServiceRunning(request);
            return response;
        }
    }
}
