using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Extensions;

namespace Pdbc.Music.Core.IntegrationTests.Data.Repositories
{
    public class ArtistRepositoryTestFixture : BaseRepositoryTestFixture<Artist>
    {
        protected override Artist CreateExistingItem()
        {
            return new ArtistTestDataBuilder()
                .Build();
        }

        protected override Artist CreateNewItem()
        {
            return new ArtistTestDataBuilder()
                .Build();
        }

        protected override void EditItem(Artist entity)
        {
            entity.Name = UnitTestValueGenerator.GenerateRandomCode();
        }
    }
}