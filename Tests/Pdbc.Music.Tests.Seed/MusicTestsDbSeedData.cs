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
        private readonly MusicTestsDataObjects _objects;

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
            SeedAlbums();
            SeedPlaylists();
        }



        private void SeedGenres()
        {
            SeedGenreIfNotExists(_dbContext, MusicTestsDataObjectsValues.GenreA);
            SeedGenreIfNotExists(_dbContext, MusicTestsDataObjectsValues.GenreB);
            SeedGenreIfNotExists(_dbContext, MusicTestsDataObjectsValues.GenreC);


            _dbContext.SaveChanges();

            _objects.LoadGenres();


        }
        private void SeedArtists()
        {
            SeedArtistIfNotExists(_dbContext, MusicTestsDataObjectsValues.ArtistA);
            SeedArtistIfNotExists(_dbContext, MusicTestsDataObjectsValues.ArtistB);
            SeedArtistIfNotExists(_dbContext, MusicTestsDataObjectsValues.ArtistC);


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
        private void SeedAlbums()
        {
            SeedAlbumIfNotExists(_dbContext, MusicTestsDataObjectsValues.AlbumA, _objects.SongA);
            SeedAlbumIfNotExists(_dbContext, MusicTestsDataObjectsValues.AlbumB, _objects.SongA, _objects.SongB);
            SeedAlbumIfNotExists(_dbContext, MusicTestsDataObjectsValues.AlbumC);


            _dbContext.SaveChanges();


            _objects.LoadAlbums();
        }

        private void SeedPlaylists()
        {
            SeedPlaylistIfNotExists(_dbContext, MusicTestsDataObjectsValues.PlaylistA, _objects.SongA);
            SeedPlaylistIfNotExists(_dbContext, MusicTestsDataObjectsValues.PlaylistB, _objects.SongA, _objects.SongB);
            SeedPlaylistIfNotExists(_dbContext, MusicTestsDataObjectsValues.PlaylistC);


            _dbContext.SaveChanges();


            _objects.LoadPlaylists();
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
        private static void SeedAlbumIfNotExists(MusicDbContext dbContext, String name, params Song[] songs)
        {
            var item = dbContext.Albums.FirstOrDefault(x => x.Name == name);
            if (item == null)
            {
                dbContext.Albums.Add(new AlbumBuilder()
                    .WithName(name)
                    .WithSongs(songs)
                    .Build());
            }
        }
        private static void SeedPlaylistIfNotExists(MusicDbContext dbContext, String name, params Song[] songs)
        {
            var item = dbContext.Playlists.FirstOrDefault(x => x.Name == name);
            if (item == null)
            {
                dbContext.Playlists.Add(new PlaylistBuilder()
                    .WithName(name)
                    .WithSongs(songs)
                    .Build());
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