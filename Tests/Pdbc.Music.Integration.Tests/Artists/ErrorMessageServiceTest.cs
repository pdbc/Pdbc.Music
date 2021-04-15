using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests;
using Pdbc.Music.Data;

namespace Pdbc.Music.Integration.Tests.Artists
{
    public abstract class ArtistsServiceTest<Result> : IntegrationTest<Result> where Result : MusicResponse
    {
        protected IArtistService Service;

        protected ArtistsServiceTest(IArtistService service, MusicDbContext dbContext) : base(dbContext)
        {
            Service = service;
        }
    }
}
