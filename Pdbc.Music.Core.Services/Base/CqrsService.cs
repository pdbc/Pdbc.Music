using AutoMapper;
using MediatR;
using Pdbc.Music.Api.Contracts.Requests;
using Pdbc.Music.Common.Validation;
using System.Threading.Tasks;

namespace Pdbc.Music.Core.Services
{
    public class CqrsService
    {
        protected readonly IMediator _mediator;
        protected readonly IMapper _mapper;
        private readonly ValidationBag _validationBag;

        public CqrsService(IMediator mediator, IMapper mapper, ValidationBag validationBag)
        {
            _mediator = mediator;
            _mapper = mapper;
            _validationBag = validationBag;
        }

        protected async Task<TResponse> Query<TRequest, TQuery, TResult, TResponse>(TRequest request) where TResponse : IMusicResponse
        {
            var query = _mapper.Map<TRequest, TQuery>(request);
            var result = await _mediator.Send(query);

            var response = _mapper.Map<TResult, TResponse>((TResult)result);
            response.Notifications = _validationBag.ToValidationResult();

            return response;
        }
    }
}