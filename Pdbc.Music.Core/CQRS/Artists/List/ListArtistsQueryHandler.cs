using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Pdbc.Music.Core.CQRS.ErrorMessages.List;
using Pdbc.Music.Core.Extensions;
using Pdbc.Music.Data.Repositories;
using Pdbc.Music.Dto.Artists;

namespace Pdbc.Music.Core.CQRS.Artists.List
{
    public class ListArtistsQueryHandler : IRequestHandler<ListArtistsQuery, ListArtistsViewModel>
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IConfigurationProvider _configurationProvider;

        public ListArtistsQueryHandler(IArtistRepository artistRepository, 
                                        IConfigurationProvider  configurationProvider)
        {
            _artistRepository = artistRepository;
            _configurationProvider = configurationProvider;
        }
        public Task<ListArtistsViewModel> Handle(ListArtistsQuery request, CancellationToken cancellationToken)
        {
            var artists =_artistRepository
                .GetAll()
                .ProjectTo<ArtistListItem>(_configurationProvider);

            var result = new ListArtistsViewModel()
            {
                
            };

            return Task.FromResult(result);
        }
    }
}