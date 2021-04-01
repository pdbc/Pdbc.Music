using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pdbc.Music.Api.Common.Controllers;

namespace Pdbc.Music.Api.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistsController : MusicBaseController
    {
        ///// <summary>
        ///// Gets all artists
        ///// </summary>
        ///// <returns>An ActionResult of type IEnumerable of Author</returns>
        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<ActionResult<IEnumerable<Artist>>> GetAuthors()
        //{
        //    var authorsFromRepo = await _authorsRepository.GetAuthorsAsync();
        //    return Ok(_mapper.Map<IEnumerable<Author>>(authorsFromRepo));
        //}
    }
}
