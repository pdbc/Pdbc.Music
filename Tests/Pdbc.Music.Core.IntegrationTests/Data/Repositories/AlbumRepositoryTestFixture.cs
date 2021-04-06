using NUnit.Framework;
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

        [Test]
        public void Verify_song_is_not_deleted_when_album_is_deleted()
        {
            // add dependent object
            var song = MusicObjects.SongA;
            ExistingItem.Songs.Add(song);
            Context.SaveChanges();

            base.VerifyDependentObjectIsNotDeletedWhenDeletingEntity(song, ExistingItem);
        }
    }
}