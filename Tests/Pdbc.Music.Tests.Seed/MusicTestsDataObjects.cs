using System;
using System.Linq;
using Pdbc.Music.Data;
using Pdbc.Music.Data.Seed;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Tests.Seed
{
    public class MusicTestsDataObjects : IHaveDataObjects
    {
        private readonly MusicDbContext _context;
        
        public MusicTestsDataObjects(MusicDbContext context)
        {
            _context = context;
        }

        public void LoadObjects()
        {
            LoadGenres();
            LoadArtists();
            LoadSongs();
        }

        public void LoadSongs()
        {
            SongA = GetSongFor(MusicTestsDataObjectsValues.SongTitleA);
            SongB = GetSongFor(MusicTestsDataObjectsValues.SongTitleB);
        }

        public void LoadArtists()
        {
            ArtistA = GetArtistFor(MusicTestsDataObjectsValues.ArtistA);
            ArtistB = GetArtistFor(MusicTestsDataObjectsValues.ArtistB);
        }

        public void LoadGenres()
        {
            GenreA = GetGenreFor(MusicTestsDataObjectsValues.GenreA);
            GenreB = GetGenreFor(MusicTestsDataObjectsValues.GenreB);

        }
        public Artist ArtistA { get; set; }
        public Artist ArtistB { get; set; }

        public Genre GenreA { get; set; }
        public Genre GenreB { get; set; }
        
        public Song SongA { get; set; }
        public Song SongB { get; set; }


        public Genre GetGenreFor(String name)
        {
            var item = _context.Genres.FirstOrDefault(x => x.Name == name);
            return item;
        }

        public Artist GetArtistFor(String name)
        {
            var item = _context.Artists.FirstOrDefault(x => x.Name == name);
            return item;
        }
        public Song GetSongFor(String name)
        {
            var item = _context.Songs.FirstOrDefault(x => x.Title == name);
            return item;
        }


    }
}