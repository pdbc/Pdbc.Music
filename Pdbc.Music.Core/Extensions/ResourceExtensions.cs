using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pdbc.Music.I18N;

namespace Pdbc.Music.Core.Extensions
{
    public static class ResourceExtensions
    {
        /// <summary>
        /// Get All resources for a given language
        /// </summary>
        /// <param name="language">The language</param>
        /// <returns></returns>
        public static IDictionary<string, string> GetResources(this string language)
        {
            // Common resources
            var commonNotifications = CommonResources.ResourceManager.CreateCaseInsensitiveSpecificResourceData(language);

            // Resources
            IEnumerable<KeyValuePair<string, string>> resources = commonNotifications;

            // Add Error Resources
            var errorNotifications = ErrorResources.ResourceManager.CreateCaseInsensitiveSpecificResourceData(language);
            resources = resources.Union(errorNotifications);


            return resources.GroupBy(r => r.Key, StringComparer.OrdinalIgnoreCase)
                            .ToDictionary(x => x.Key, x => x.Last().Value);
        }

        /// <summary>
        /// Get All resources for a given language
        /// </summary>
        /// <param name="language">The language</param>
        /// <returns></returns>
        public static IDictionary<string, string> GetErrorResources(this string language)
        {
            // Add Error Resources
            return ErrorResources.ResourceManager.CreateCaseInsensitiveSpecificResourceData(language);
        }


        /// <summary>
        /// Get All resources for a given language
        /// </summary>
        /// <param name="language">The language</param>
        /// <returns></returns>
        public static string GetErrorResource(this string language, string key)
        {
            // Add Error Resources
            var errorResources = ErrorResources.ResourceManager.CreateCaseInsensitiveSpecificResourceData(language);

            var translation = errorResources.FirstOrDefault(kvp => kvp.Key.Equals(key, StringComparison.OrdinalIgnoreCase));
            return translation.Value;
        }
    }
}
