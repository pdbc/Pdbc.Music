using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Extensions;

namespace Pdbc.Music.Core.IntegrationTests.Data.Repositories
{
    public class AlbumRepositoryTestFixture : BaseRepositoryTestFixture<Album>
    {
        protected override Album CreateExistingItem()
        {
            return new AlbumTestDataBuilder()
                .Build();
        }

        protected override Album CreateNewItem()
        {
            return new AlbumTestDataBuilder()
                .Build();
        }

        protected override void EditItem(Album entity)
        {
            entity.Name = UnitTestValueGenerator.GenerateRandomCode();
        }
    }
}