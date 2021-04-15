using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Extensions;
using System;

namespace Pdbc.Music.UnitTest.Helpers.Domain.Model
{
    public class SongTestDataBuilder : SongBuilder
    {
        public SongTestDataBuilder()
        {
            Title = UnitTestValueGenerator.GenerateRandomCode();
            //Genres = new List<Genre>()
            //{
            //    new GenreTestDataBuilder()
            //};
            //Album = new AlbumTestDataBuilder();
            //FileInformation = new FileInformationTestDataBuilder();
            Year = 1999;
            Duration = new TimeSpan(0, 3, 23);
            //Artists = new List<Artist>()
            //{
            //    new ArtistTestDataBuilder()
            //};
        }

    }
}