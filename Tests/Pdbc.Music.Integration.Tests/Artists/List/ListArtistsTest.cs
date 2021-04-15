using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Artists;
using Pdbc.Music.Data;
using Pdbc.Music.Integration.Tests.Errors;
using Pdbc.Music.UnitTests.Base;

namespace Pdbc.Music.Integration.Tests.Artists.List
{
    public class ListArtistsTest : ArtistsServiceTest<ListArtistsResponse>
    {
        public ListArtistsTest(IArtistService service, MusicDbContext dbContext) 
            : base(service, dbContext)
        {
        }

        private ListArtistsRequest _request;

        public override void Setup()
        {
            _request = new ListArtistsRequest()
            {
            };
        }

        public override void Cleanup()
        {
        }

        public override ListArtistsResponse PerformAction()
        {
            return Service.ListArtists(_request)
                        .GetAwaiter()
                        .GetResult();
        }

        public override void VerifyResponse(ListArtistsResponse response)
        {
            response.ShouldNotBeNull();
            response.Items.ShouldNotBeNull();
            response.Items.Count.ShouldBeGreaterThan(0);
        }
    }
}
