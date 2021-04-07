using System;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;

using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Core.CQRS.Errors.List;

namespace Pdbc.Music.Core.Services
{
    public class ErrorService : IErrorService
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ErrorService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<ListErrorMessagesResponse> ListErrorMessages(ListErrorMessagesRequest request)
        {
            var query = _mapper.Map<ListErrorMessagesRequest, ListErrorMessagesQuery>(request);
            ListErrorMessagesQueryResult result = await _mediator.Send(query);
            return _mapper.Map<ListErrorMessagesQueryResult, ListErrorMessagesResponse>(result);
        }

        public Task<GetErrorResponse> GetErrorMessage(GetErrorRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
