using AutoMapper;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.Dto.Artists;

namespace Pdbc.Music.Core.Mappings
{
    public class ArtistDtoMappings : Profile
    {
        public ArtistDtoMappings()
        {
            CreateMap<Artist, ArtistInfo>();
            CreateMap<Artist, ArtistListItem>();
        }
    }
}
