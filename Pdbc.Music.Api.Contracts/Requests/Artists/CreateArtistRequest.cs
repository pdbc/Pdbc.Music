using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pdbc.Music.Api.Contracts.Attributes;
using Pdbc.Music.Api.Contracts.Dto.Artists;
using Pdbc.Music.Api.Contracts.Enum;

namespace Pdbc.Music.Api.Contracts.Requests.Artists
{
    /// <summary>
    /// Request to create a new artist
    /// </summary>
    [HttpAction("artists", Method.Post)]
    public class CreateArtistRequest : IMusicRequest
    {
        /// <summary>
        /// The details of the artist that needs to be created.
        /// </summary>
        public CreateArtistDto Artist { get; set; }
    }
}
