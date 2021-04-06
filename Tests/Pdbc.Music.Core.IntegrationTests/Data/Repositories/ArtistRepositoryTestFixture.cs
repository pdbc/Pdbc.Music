using NUnit.Framework;
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

        [Test]
        public void Verify_song_is_not_deleted_when_artist_is_deleted()
        {
            // add dependent object
            var song = MusicObjects.SongA;
            ExistingItem.Songs.Add(song);
            Context.SaveChanges();

            base.VerifyDependentObjectIsNotDeletedWhenDeletingEntity(song, ExistingItem);
        }
    }
}