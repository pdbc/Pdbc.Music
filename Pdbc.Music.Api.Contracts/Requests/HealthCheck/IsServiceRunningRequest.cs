using Pdbc.Music.Api.Contracts.Attributes;
using Pdbc.Music.Api.Contracts.Enum;

namespace Pdbc.Music.Api.Contracts.Requests.HealthCheck
{
    /// <summary>
    /// Request to verify if the service is running
    /// </summary>
    [HttpAction("healthcheck/isServiceRunning", Method.Get)]
    public class IsServiceRunningRequest : IMusicRequest
    {

    }

    /// <summary>
    /// The response if the service in running
    /// </summary>
    /// <seealso cref="MusicResponse" />
    public class IsServiceRunningResponse : MusicResponse
    {

    }
}
