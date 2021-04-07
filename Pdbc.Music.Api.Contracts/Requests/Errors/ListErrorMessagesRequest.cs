using System.Collections.Generic;
using Pdbc.Music.Api.Contracts.Attributes;
using Pdbc.Music.Api.Contracts.Enum;

namespace Pdbc.Music.Api.Contracts.Requests.Errors
{
    /// <summary>
    /// Request to retrieve all the possible errors from the API
    /// </summary>
    [HttpAction("errors/{Language}", Method.Get)]
    public class ListErrorMessagesRequest
    {
        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        public string Language { get; set; }
    }

    /// <summary>
    /// all errors in the specific language
    /// </summary>
    /// <seealso cref="MusicResponse" />
    public class ListErrorMessagesResponse : MusicResponse
    {
        /// <summary>
        /// Gets the messages in the specific language
        /// </summary>
        /// <value>
        /// The resources.
        /// </value>
        public IDictionary<string, string> Resources { get; set; }
    }
}