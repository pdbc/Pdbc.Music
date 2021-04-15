using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;

namespace Pdbc.Music.Core.Extensions
{
    public static class ResourceManagerExtensions
    {
        public static IDictionary<string, string> CreateCaseInsensitiveSpecificResourceData(this ResourceManager resourceManager,
            string language)
        {
            return resourceManager.CreateSpecificResourceData(language, StringComparer.OrdinalIgnoreCase);
        }

        public static IDictionary<string, string> CreateSpecificResourceData(this ResourceManager resourceManager,
            string language,
            StringComparer comparer = null)
        {
            if (resourceManager == null)
                return new Dictionary<string, string>(comparer);

            var languageShort = language.ToCultureInfo();
            var resourceSet = resourceManager.GetResourceSet(languageShort, true, false);

            var data = new Dictionary<string, string>(comparer);
            if (resourceSet != null)
            {
                data = resourceSet
                    .Cast<DictionaryEntry>()
                    .ToDictionary(entry => entry.Key.ToString(), entry => entry.Value.ToString());
            }

            var parentResourceData = resourceManager.GetResourceSet(new CultureInfo(""), true, true)
                .Cast<DictionaryEntry>()
                .ToDictionary(x => x.Key.ToString(), x => x.Value.ToString());

            foreach (var entry in parentResourceData)
            {
                if (data.ContainsKey(entry.Key))
                    continue;

                data.Add(entry.Key, entry.Value);
            }

            return new Dictionary<string, string>(data, comparer);
        }
    }
}