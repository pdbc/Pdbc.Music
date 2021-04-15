using System;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;

using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Artists;
using Pdbc.Music.Common.Validation;
using Pdbc.Music.Core.CQRS.Artists.List;

namespace Pdbc.Music.Core.Services
{
    public class ArtistCqrsService : CqrsService, IArtistService
    {
        public ArtistCqrsService(IMediator mediator, IMapper mapper, ValidationBag validationBag) 
            : base(mediator, mapper, validationBag)
        {
        }

        public Task CreateArtist(CreateArtistRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ListArtistsResponse> ListArtists(ListArtistsRequest request)
        {
            return await base.Query<ListArtistsRequest, ListArtistsQuery, 
                ListArtistsViewModel, ListArtistsResponse>(request);
        }


    }
}
