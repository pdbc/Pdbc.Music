using Pdbc.Music.Api.Contracts.Attributes;
using Pdbc.Music.Api.Contracts.Enum;
using Pdbc.Music.Dto.Artists;
using System.Collections.Generic;

namespace Pdbc.Music.Api.Contracts.Requests.Artists
{
    /// <summary>
    /// Request to query a list of artists
    /// </summary>
    [HttpAction("artists", Method.Get)]
    public class ListArtistsRequest : IMusicRequest
    {

    }

    /// <summary>
    /// The response containing the artists related to your query request.
    /// </summary>
    public class ListArtistsResponse : MusicResponse
    {
        /// <summary>
        /// The artists to return
        /// </summary>
        public IList<ArtistListItem> Items { get; set; }
    }
}