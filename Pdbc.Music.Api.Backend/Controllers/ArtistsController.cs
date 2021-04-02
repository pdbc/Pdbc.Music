using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pdbc.Music.Api.Common.Controllers;
using Pdbc.Music.Api.Contracts.Requests.Artists;

namespace Pdbc.Music.Api.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistsController : MusicBaseController
    {
        /// <summary>
        /// Gets all artists from the music library
        /// </summary>
        /// <returns>An ActionResult of type ListArtistsResponse</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ListArtistsResponse>> GetArtists(ListArtistsRequest request)
        {
            return null;
        }
    }
}
