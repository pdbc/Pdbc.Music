using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Pdbc.Music.Api.Common.Extensions
{
    public static class ApiVersionExtensions
    {

        public static void SetVersion(this ApiExplorerOptions options)
        {
            options.GroupNameFormat = "'v'VV";
        }
    }
}