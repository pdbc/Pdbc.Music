using System.Threading.Tasks;
using AutoMapper;
using MediatR;

namespace Pdbc.Music.Core.Services
{
    public class CqrsService
    {
        protected readonly IMediator _mediator;
        protected readonly IMapper _mapper;

        public CqrsService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        protected async Task<TResponse> Query<TRequest, TQuery, TResult, TResponse>(TRequest request)
        {
            var query = _mapper.Map<TRequest, TQuery>(request);
            var result = await _mediator.Send(query);
            return _mapper.Map<TResult, TResponse>((TResult)result);
        }
    }
}