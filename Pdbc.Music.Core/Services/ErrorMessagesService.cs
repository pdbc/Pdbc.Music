using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Core.CQRS.Errors.List;

namespace Pdbc.Music.Core.Services
{
    public class ErrorService : IErrorService
    {
        private readonly IMediator _mediator;

        public ErrorService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ListErrorsResponse> ListErrorMessages(ListErrorsRequest request)
        {
            // Map Request to Query/Command
            var query = new ListErrorMessagesQuery();

            // Call mediator
            var result = await _mediator.Send(query);

            // Map Result to Response
            return new ListErrorsResponse();
        }

        public Task<GetErrorResponse> GetErrorMessage(GetErrorRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
