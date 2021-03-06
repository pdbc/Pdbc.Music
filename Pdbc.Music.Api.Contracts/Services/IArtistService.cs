using Pdbc.Music.Api.Contracts.Requests.Artists;
using System.Threading.Tasks;

namespace Pdbc.Music.Api.Contracts
{
    /// <summary>
    /// Service for all actions around the artist entity
    /// </summary>
    public interface IArtistService
    {
        /// <summary>
        /// Creates a new artist
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task CreateArtist(CreateArtistRequest request);

        /// <summary>
        /// List all artists
        /// </summary>
        /// <param name="request"></param>
        Task<ListArtistsResponse> ListArtists(ListArtistsRequest request);
    }
}