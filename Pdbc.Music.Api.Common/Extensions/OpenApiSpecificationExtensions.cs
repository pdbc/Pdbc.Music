using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pdbc.Music.Api.Common.Extensions
{
    public static class OpenApiSpecificationExtensions
    {
        public static void RegisterProducesTypes(this MvcOptions options)
        {
            options.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status400BadRequest));
            options.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status401Unauthorized));
            options.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status417ExpectationFailed));
            options.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status500InternalServerError));
            
            options.Filters.Add(new ProducesDefaultResponseTypeAttribute());
        }
    }
}
