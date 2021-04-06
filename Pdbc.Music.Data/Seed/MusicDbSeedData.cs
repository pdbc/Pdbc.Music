using System;
using System.Linq;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data.Seed
{
    public interface IMusicDbSeedData : ISeedData
    {
    }
    public class MusicDbSeedData : IMusicDbSeedData
    {
        private readonly MusicDbContext _dbContext;

        public MusicDbSeedData(MusicDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Seed()
        {
            SeedGenres();
            SeedArtists();
        }

        private void SeedGenres()
        {
            SeedGenreIfNotExists(_dbContext, MusicDataObjectsValues.GenreLatin);
            SeedGenreIfNotExists(_dbContext, MusicDataObjectsValues.GenreSchlager);
            SeedGenreIfNotExists(_dbContext, MusicDataObjectsValues.GenreJazz);
            SeedGenreIfNotExists(_dbContext, MusicDataObjectsValues.GenreRenB);
            SeedGenreIfNotExists(_dbContext, MusicDataObjectsValues.GenreRock);
            SeedGenreIfNotExists(_dbContext, MusicDataObjectsValues.GenrePop);
            SeedGenreIfNotExists(_dbContext, MusicDataObjectsValues.GenreElectricMusic);
            SeedGenreIfNotExists(_dbContext, MusicDataObjectsValues.GenreFolk);
            SeedGenreIfNotExists(_dbContext, MusicDataObjectsValues.GenreDutch);

            _dbContext.SaveChanges();
        }
        private void SeedArtists()
        {
            SeedArtistIfNotExists(_dbContext, MusicDataObjectsValues.Artist2Pac);
            SeedArtistIfNotExists(_dbContext, MusicDataObjectsValues.ArtistAerosmith);
            SeedArtistIfNotExists(_dbContext, MusicDataObjectsValues.ArtistAvicii);
            SeedArtistIfNotExists(_dbContext, MusicDataObjectsValues.ArtistEminem);
            SeedArtistIfNotExists(_dbContext, MusicDataObjectsValues.ArtistJonBonJovi);
            SeedArtistIfNotExists(_dbContext, MusicDataObjectsValues.ArtistQueen);
            SeedArtistIfNotExists(_dbContext, MusicDataObjectsValues.ArtistU2);


            _dbContext.SaveChanges();
        }

        private static void SeedGenreIfNotExists(MusicDbContext dbContext, String name)
        {
            var genre = dbContext.Genres.FirstOrDefault(x => x.Name == name);
            if (genre == null)
            {
                dbContext.Genres.Add(new GenreBuilder().WithName(name).Build());
            }
        }

        private static void SeedArtistIfNotExists(MusicDbContext dbContext, String name)
        {
            var genre = dbContext.Artists.FirstOrDefault(x => x.Name == name);
            if (genre == null)
            {
                dbContext.Artists.Add(new ArtistBuilder().WithName(name).Build());
            }
        }
    }
}