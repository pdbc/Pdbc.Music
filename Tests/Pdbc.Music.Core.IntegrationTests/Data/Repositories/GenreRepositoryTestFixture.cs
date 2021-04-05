using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Extensions;

namespace Pdbc.Music.Core.IntegrationTests.Data.Repositories
{
    public class GenreRepositoryTestFixture : BaseRepositoryTestFixture<Genre>
    {
        protected override Genre CreateExistingItem()
        {
            return new GenreTestDataBuilder()
                .Build();
        }

        protected override Genre CreateNewItem()
        {
            return new GenreTestDataBuilder()
                .Build();
        }

        protected override void EditItem(Genre entity)
        {
            entity.Name = UnitTestValueGenerator.GenerateRandomCode();
        }
    }
}
