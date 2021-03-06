using NUnit.Framework;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Extensions;

namespace Pdbc.Music.Core.IntegrationTests.Data.Repositories
{
    public class PlaylistRepositoryTestFixture : BaseRepositoryTestFixture<Playlist>
    {
        protected override Playlist CreateExistingItem()
        {
            return new PlaylistTestDataBuilder()
                .Build();
        }

        protected override Playlist CreateNewItem()
        {
            return new PlaylistTestDataBuilder()
                .Build();
        }

        protected override void EditItem(Playlist entity)
        {
            entity.Name = UnitTestValueGenerator.GenerateRandomCode();
        }

        [Test]
        public void Verify_song_is_not_deleted_when_playlist_is_deleted()
        {
            // add dependent object
            var song = MusicObjects.SongA;
            ExistingItem.Songs.Add(song);
            Context.SaveChanges();

            base.VerifyDependentObjectIsNotDeletedWhenDeletingEntity(song, ExistingItem);
        }
    }
}
