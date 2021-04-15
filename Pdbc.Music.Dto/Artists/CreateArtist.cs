using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdbc.Music.Dto.Artists
{
    /// <summary>
    ///  Marker interface for creating an artist
    /// </summary>
    /// <seealso cref="ICreateArtist" />
    public interface ICreateArtist : IArtistInfo
    {
      
    }


    /// <inheritdoc />
    public class CreateArtist : ICreateArtist
    {
        /// <inheritdoc />
        public string Name { get; set; }

    }
}
