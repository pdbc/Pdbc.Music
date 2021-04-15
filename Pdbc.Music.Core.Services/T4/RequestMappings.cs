
using AutoMapper;

public class RequestToCqrsMappings : Profile
{
    public RequestToCqrsMappings()
    {
        // CreateArtistDto
        // CreateArtistRequest
        CreateMap<Pdbc.Music.Api.Contracts.Requests.Artists.ListArtistsRequest, Pdbc.Music.Core.CQRS.Artists.List.ListArtistsQuery>();
        // ListArtistsRequest
        CreateMap<Pdbc.Music.Core.CQRS.Artists.List.ListArtistsViewModel, Pdbc.Music.Api.Contracts.Requests.Artists.ListArtistsResponse>();
        // ListArtistsResponse
        // MusicRequest
        // MusicResponse
        CreateMap<Pdbc.Music.Api.Contracts.Requests.Errors.GetErrorMessageRequest, Pdbc.Music.Core.CQRS.ErrorMessages.Get.GetErrorMessageQuery>();
        // GetErrorMessageRequest
        CreateMap<Pdbc.Music.Core.CQRS.ErrorMessages.Get.GetErrorMessageViewModel, Pdbc.Music.Api.Contracts.Requests.Errors.GetErrorMessageResponse>();
        // GetErrorMessageResponse
        CreateMap<Pdbc.Music.Api.Contracts.Requests.Errors.ListErrorMessagesRequest, Pdbc.Music.Core.CQRS.ErrorMessages.List.ListErrorMessagesQuery>();
        // ListErrorMessagesRequest
        CreateMap<Pdbc.Music.Core.CQRS.ErrorMessages.List.ListErrorMessagesViewModel, Pdbc.Music.Api.Contracts.Requests.Errors.ListErrorMessagesResponse>();
        // ListErrorMessagesResponse
        CreateMap<Pdbc.Music.Api.Contracts.Requests.HealthCheck.IsServiceRunningRequest, Pdbc.Music.Core.CQRS.HealthCheck.IsServiceRunning.IsServiceRunningQuery>();
        // IsServiceRunningRequest
        CreateMap<Pdbc.Music.Core.CQRS.HealthCheck.IsServiceRunning.IsServiceRunningViewModel, Pdbc.Music.Api.Contracts.Requests.HealthCheck.IsServiceRunningResponse>();
        // IsServiceRunningResponse
    }
}