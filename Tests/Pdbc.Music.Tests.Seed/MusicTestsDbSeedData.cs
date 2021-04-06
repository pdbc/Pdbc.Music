using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pdbc.Music.Data;
using Pdbc.Music.Data.Repositories;
using Pdbc.Music.Data.Seed;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Tests.Seed
{
    public interface IMusicTestsDbSeedData : ISeedData
    {
    }
    public class MusicTestsDbSeedData : IMusicTestsDbSeedData
    {
        private readonly MusicDbContext _dbContext;
        private MusicTestsDataObjects _objects;

        public MusicTestsDbSeedData(MusicDbContext dbContext)
        {
            this._dbContext = dbContext;
            _objects = new MusicTestsDataObjects(dbContext);
        }

        public void Seed()
        {
            SeedGenres();
            SeedArtists();
            SeedSongs();
        }



        private void SeedGenres()
        {
            SeedGenreIfNotExists(_dbContext, MusicTestsDataObjectsValues.GenreA);
            SeedGenreIfNotExists(_dbContext, MusicTestsDataObjectsValues.GenreB);

            _dbContext.SaveChanges();

            _objects.LoadGenres();


        }
        private void SeedArtists()
        {
            SeedArtistIfNotExists(_dbContext, MusicTestsDataObjectsValues.ArtistA);
            SeedArtistIfNotExists(_dbContext, MusicTestsDataObjectsValues.ArtistB);


            _dbContext.SaveChanges();


            _objects.LoadArtists();
        }
        private void SeedSongs()
        {
            SeedSongIfNotExists(_dbContext, MusicTestsDataObjectsValues.SongTitleA, _objects.GenreA, _objects.ArtistA);
            SeedSongIfNotExists(_dbContext, MusicTestsDataObjectsValues.SongTitleB, _objects.GenreB, _objects.ArtistB);


            _dbContext.SaveChanges();


            _objects.LoadSongs();
        }
        private static void SeedGenreIfNotExists(MusicDbContext dbContext, String name)
        {
            var item = dbContext.Genres.FirstOrDefault(x => x.Name == name);
            if (item == null)
            {
                dbContext.Genres.Add(new GenreBuilder().WithName(name).Build());
            }
        }

        private static void SeedArtistIfNotExists(MusicDbContext dbContext, String name)
        {
            var item = dbContext.Artists.FirstOrDefault(x => x.Name == name);
            if (item == null)
            {
                dbContext.Artists.Add(new ArtistBuilder().WithName(name).Build());
            }
        }

        private static void SeedSongIfNotExists(MusicDbContext dbContext, String name, Genre genre, Artist artist)
        {
            var item = dbContext.Songs.FirstOrDefault(x => x.Title == name);
            if (item == null)
            {
                dbContext.Songs.Add(new SongBuilder()
                    .WithTitle(name)
                    .AddGenresItem(genre)
                    .AddArtistsItem(artist)
                    .Build());
            }
        }
    }
}