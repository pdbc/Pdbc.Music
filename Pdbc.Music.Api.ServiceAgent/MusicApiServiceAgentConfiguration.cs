using System;
using Microsoft.Extensions.Configuration;

namespace Pdbc.Music.Api.ServiceAgent
{
    /// <summary>
    /// Configuration to configure the connection with the Music API
    /// </summary>
    public interface IMusicApiServiceAgentConfiguration
    {
        /// <summary>
        /// Name of the HttpClient
        /// </summary>
        String Name { get; set; }

        /// <summary>
        /// Gets the base URL for the Functionality Domain API
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        String BaseUrl { get; }

    }

    /// <inheritdoc />
    public class MusicApiServiceAgentConfiguration : IMusicApiServiceAgentConfiguration
    {
        /// <summary>
        /// Constructor for the configuration
        /// </summary>
        /// <param name="configuration"></param>
        public MusicApiServiceAgentConfiguration(IConfiguration configuration)
        {
            configuration.GetSection("serviceagent:musicApi").Bind(this);
        }

        public string Name { get; set; }

        /// <inheritdoc />
        public string BaseUrl { get; set; }

    }
}