using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Extensions;

namespace Pdbc.Music.Core.IntegrationTests.Data.Repositories
{
    public class FileInformationRepositoryTestFixture : BaseRepositoryTestFixture<FileInformation>
    {
        protected override FileInformation CreateExistingItem()
        {
            return new FileInformationTestDataBuilder()
                .Build();
        }

        protected override FileInformation CreateNewItem()
        {
            return new FileInformationTestDataBuilder()
                .Build();
        }

        protected override void EditItem(FileInformation entity)
        {
            entity.Filename = UnitTestValueGenerator.GenerateRandomCode();
        }
    }
}
