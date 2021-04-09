﻿using System;
using System.Threading.Tasks;

using MediatR;

using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Artists;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Core.CQRS.Errors.List;

namespace Pdbc.Music.Core.Services
{
    public class ArtistService : IArtistService
    {
        private readonly IMediator _mediator;

        public ArtistService(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        public Task CreateArtist(CreateArtistRequest request)
        {
            throw new NotImplementedException();
        }
    }
}