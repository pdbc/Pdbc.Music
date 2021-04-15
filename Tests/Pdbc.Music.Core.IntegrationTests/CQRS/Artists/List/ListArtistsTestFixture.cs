using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Core.Services;
using Pdbc.Music.Integration.Tests;
using Pdbc.Music.Integration.Tests.Artists.List;

namespace Pdbc.Music.Core.IntegrationTests.CQRS.Artists.List
{
    public class ListArtistsTestFixture : MusicIntegrationCqrsRequestTestFixture
    {
        protected override IIntegrationTest CreateIntegrationTest()
        {
            var service = ServiceProvider.GetRequiredService<IArtistCqrsService>();
            return new ListArtistsTest(service, base.Context);
        }
    }
}