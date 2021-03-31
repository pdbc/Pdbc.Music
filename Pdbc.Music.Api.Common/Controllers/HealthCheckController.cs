using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pdbc.Music.Api.Common.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet(Name = nameof(IsRunning))]
        public async Task<ActionResult<String>> IsRunning()
        {
            return await Task.FromResult(Ok("Running correct"));
        }
    }
}
