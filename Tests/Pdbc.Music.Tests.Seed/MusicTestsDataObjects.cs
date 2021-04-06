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

        public Song SongA { get; set; }
        public Song SongB { get; set; }
        
        public void LoadSongs()
        {
            SongA = GetSongFor(MusicTestsDataObjectsValues.SongTitleA);
            SongB = GetSongFor(MusicTestsDataObjectsValues.SongTitleB);
        }

        public Artist ArtistA { get; set; }
        public Artist ArtistB { get; set; }
        public Artist ArtistC { get; set; }

        public void LoadArtists()
        {
            ArtistA = GetArtistFor(MusicTestsDataObjectsValues.ArtistA);
            ArtistB = GetArtistFor(MusicTestsDataObjectsValues.ArtistB);
            ArtistC = GetArtistFor(MusicTestsDataObjectsValues.ArtistC);
        }

        public Genre GenreA { get; set; }
        public Genre GenreB { get; set; }
        public Genre GenreC { get; set; }
        public void LoadGenres()
        {
            GenreA = GetGenreFor(MusicTestsDataObjectsValues.GenreA);
            GenreB = GetGenreFor(MusicTestsDataObjectsValues.GenreB);
            GenreC = GetGenreFor(MusicTestsDataObjectsValues.GenreC);
        }


        public Album AlbumA { get; set; }
        public Album AlbumB { get; set; }
        public Album AlbumC { get; set; }
        public void LoadAlbums()
        {
            AlbumA = GetAlbumFor(MusicTestsDataObjectsValues.AlbumA);
            AlbumB = GetAlbumFor(MusicTestsDataObjectsValues.AlbumB);
            AlbumC = GetAlbumFor(MusicTestsDataObjectsValues.AlbumC);
        }

        public Playlist PlaylistA { get; set; }
        public Playlist PlaylistB { get; set; }
        public Playlist PlaylistC { get; set; }
        public void LoadPlaylists()
        {
            PlaylistA = GetPlaylistFor(MusicTestsDataObjectsValues.PlaylistA);
            PlaylistB = GetPlaylistFor(MusicTestsDataObjectsValues.PlaylistB);
            PlaylistC = GetPlaylistFor(MusicTestsDataObjectsValues.PlaylistC);
        }



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
        public Album GetAlbumFor(String name)
        {
            var item = _context.Albums.FirstOrDefault(x => x.Name == name);
            return item;
        }
        public Playlist GetPlaylistFor(String name)
        {
            var item = _context.Playlists.FirstOrDefault(x => x.Name == name);
            return item;
        }
    }
}