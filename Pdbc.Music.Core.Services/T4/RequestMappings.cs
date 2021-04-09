





using System;
using System.Linq;

using AutoMapper;
using Pdbc.Music.Core.CQRS.ErrorMessages.Get;
using Pdbc.Music.Core.CQRS.ErrorMessages.List;

public class RequestToCqrsMappings : Profile
{
    public RequestToCqrsMappings()
    {
                                                        CreateMap<Pdbc.Music.Api.Contracts.Requests.Errors.GetErrorMessageRequest, GetErrorMessageQuery>();
        CreateMap<GetErrorMessageViewModel, Pdbc.Music.Api.Contracts.Requests.Errors.GetErrorMessageResponse>();
        CreateMap<Pdbc.Music.Api.Contracts.Requests.Errors.ListErrorMessagesRequest, ListErrorMessagesQuery>();
        CreateMap<ListErrorMessagesViewModel, Pdbc.Music.Api.Contracts.Requests.Errors.ListErrorMessagesResponse>();
            }
}