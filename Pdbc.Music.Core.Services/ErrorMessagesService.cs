using System;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;

using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Core.CQRS.ErrorMessages.Get;
using Pdbc.Music.Core.CQRS.ErrorMessages.List;
using Pdbc.Music.Core.CQRS.Errors.Get;
using Pdbc.Music.Core.CQRS.Errors.List;

namespace Pdbc.Music.Core.Services
{
    public class ErrorMessagesService : CqrsService, IErrorMessagesCqrsService, IErrorMessagesService
    {
        public ErrorMessagesService(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }

        public async Task<ListErrorMessagesResponse> ListErrorMessages(ListErrorMessagesRequest request)
        {
            return await Query<ListErrorMessagesRequest, ListErrorMessagesQuery, 
                                    ListErrorMessagesViewModel, ListErrorMessagesResponse>(request);
         
        }

        public async Task<GetErrorMessageResponse> GetErrorMessage(GetErrorMessageRequest messageRequest)
        {
            return await Query<GetErrorMessageRequest, GetErrorMessageQuery,
                               GetErrorMessageViewModel, GetErrorMessageResponse>(messageRequest);
        }
    }
}
