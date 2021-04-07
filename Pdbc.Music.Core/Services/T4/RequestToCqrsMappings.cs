using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Core.CQRS.Errors.List;

namespace Pdbc.Music.Core.Services.T4
{
    public class RequestToCqrsMappings : Profile
    {
        public RequestToCqrsMappings()
        {
            CreateMap<ListErrorMessagesRequest, ListErrorMessagesQuery>();
            CreateMap<ListErrorMessagesQueryResult, ListErrorMessagesResponse>();
        }
    }
}
