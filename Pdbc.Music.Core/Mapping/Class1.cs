using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Pdbc.Music.Core.Mapping
{
    /// <summary>
    ///     interface to register a mapping with customization
    /// </summary>
    public interface IHaveCustomMappings
    {
        /// <summary>
        /// mapping configuration for this object
        /// </summary>
        /// <param name="configuration"></param>
        void CreateMappings(IMapperConfigurationExpression configuration);
    }
}
