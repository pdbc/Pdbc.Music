using NUnit.Framework;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Extensions;

namespace Pdbc.Music.Core.IntegrationTests.Data.Repositories
{
    public class SongRepositoryTestFixture : BaseRepositoryTestFixture<Song>
    {
        protected override Song CreateExistingItem()
        {
            return new SongTestDataBuilder()
                .Build();
        }

        protected override Song CreateNewItem()
        {
            return new SongTestDataBuilder()
                .Build();
        }

        protected override void EditItem(Song entity)
        {
            entity.Title = UnitTestValueGenerator.GenerateRandomCode();
        }

        [Test]
        public void Verify_verify_genre_is_not_deleted_when_song_is_deleted()
        {
            // add dependent object
            var genre = MusicObjects.GenreA;
            ExistingItem.Genres.Add(genre);
            Context.SaveChanges();

            base.VerifyDependentObjectIsNotDeletedWhenDeletingEntity(genre, ExistingItem);
        }

        [Test]
        public void Verify_verify_file_information_is_deleted_when_song_is_deleted()
        {
            // add dependent object
            var fileInformation = TestCaseService.SetupFileInformation(ExistingItem);

            base.VerifyDependentObjectIsDeletedWhenDeletingEntity(fileInformation, ExistingItem);
        }


    }
}
