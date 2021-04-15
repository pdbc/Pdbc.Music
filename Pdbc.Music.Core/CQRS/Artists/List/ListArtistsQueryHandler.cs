using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pdbc.Music.Data.Repositories;
using Pdbc.Music.Dto.Artists;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pdbc.Music.Core.CQRS.Artists.List
{
    public class ListArtistsQueryHandler : IRequestHandler<ListArtistsQuery, ListArtistsViewModel>
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IConfigurationProvider _configurationProvider;

        public ListArtistsQueryHandler(IArtistRepository artistRepository,
                                        IConfigurationProvider configurationProvider)
        {
            _artistRepository = artistRepository;
            _configurationProvider = configurationProvider;
        }
        public async Task<ListArtistsViewModel> Handle(ListArtistsQuery request, CancellationToken cancellationToken)
        {
            List<ArtistListItem> artists = await _artistRepository
                .GetAll()
                .ProjectTo<ArtistListItem>(_configurationProvider)
                .ToListAsync(cancellationToken);

            var result = new ListArtistsViewModel()
            {
                Items = artists
            };

            return result;
        }
    }
}