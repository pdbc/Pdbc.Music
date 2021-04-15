using System.Collections.Generic;
using Pdbc.Music.Dto.Artists;

namespace Pdbc.Music.Core.CQRS.Artists.List
{
    public class ListArtistsViewModel
    {
        public IList<ArtistListItem> Items { get; set; }
    }
}
