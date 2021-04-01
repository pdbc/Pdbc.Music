using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pdbc.Music.Api.Contracts.Requests.Errors;

namespace Pdbc.Music.Api.Common.Controllers
{
    /// <summary>
    /// Controller for REST API for Diagnostics
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("[controller]")]
    [ApiController]
    public class ErrorsController : MusicBaseController
    {
      
        /// <summary>
        /// Gets the translations for the errors in the specific language.
        /// </summary>
        /// <param name="request">The Request.</param>
        /// <returns>Returns a dictionary with all possible error keys and translations in the chosen language</returns>
        [HttpGet("{Language}")]
        [ProducesResponseType(typeof(ListErrorsResponse), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ListErrorsResponse>> ListErrorMessages([FromRoute] ListErrorsRequest request)
        {
            return base.Ok();
        }

        /// <summary>
        /// Gets the translations for a specific error key in the specific language.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Returns the translated full text of the error code if found or null.</returns>
        [HttpGet("{Language}/{Key}")]
        [ProducesResponseType(typeof(GetErrorResponse), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GetErrorResponse>> GetErrorMessage([FromRoute] GetErrorRequest request)
        {
            return Ok(); //_errorTranslationService.GetError(request));
        }
    }
}