using Pdbc.Music.Dto.Artists;
using System.Collections.Generic;

namespace Pdbc.Music.Core.CQRS.Artists.List
{
    public class ListArtistsViewModel
    {
        public IList<ArtistListItem> Items { get; set; }
    }
}
