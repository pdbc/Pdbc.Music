using NUnit.Framework;
using Pdbc.Music.Data.Extensions;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;
using Pdbc.Music.UnitTests.Base;

namespace Pdbc.Music.Core.IntegrationTests.Data
{
    public class DataRepositoryTestFixture : MusicIntegrationTestFixture
    {
        protected override void Establish_context()
        {
            base.Establish_context();
        }

        [Test]
        public void Verify_songs_flow()
        {
            //var genre = new GenreTestDataBuilder();
            var song = new SongTestDataBuilder()
                //.AddGenresItem(genre)
                .Build();

            Context.Songs.Add(song);
            Context.SaveChanges();

            Context.Songs.Remove(song);
            Context.SaveChanges();

            Context.DetachAll();

            var loaded = Context.Songs.Find(song.Id);
            loaded.ShouldBeNull();
        }
        [Test]
        public void Verify_songs_select()
        {
            //var genre = new GenreTestDataBuilder();
            var song = new SongTestDataBuilder()
            //    .AddGenresItem(genre)
                .Build();

            Context.Songs.Add(song);
            Context.SaveChanges();

            Context.DetachAll();

            var loaded = Context.Songs.Find(song.Id);
            loaded.ShouldNotBeNull();
        }
    }
}
