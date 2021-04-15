using AutoMapper;
using MediatR;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Common.Validation;
using Pdbc.Music.Core.CQRS.ErrorMessages.Get;
using Pdbc.Music.Core.CQRS.ErrorMessages.List;
using System.Threading.Tasks;

namespace Pdbc.Music.Core.Services
{
    public class ErrorMessagesCqrsService : CqrsService, IErrorMessagesCqrsService, IErrorMessagesService
    {
        public ErrorMessagesCqrsService(IMediator mediator, IMapper mapper, ValidationBag validationBag)
            : base(mediator, mapper, validationBag)
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
