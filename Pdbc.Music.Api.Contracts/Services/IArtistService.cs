using System.Threading.Tasks;
using Pdbc.Music.Api.Contracts.Requests.Artists;

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
    }
}