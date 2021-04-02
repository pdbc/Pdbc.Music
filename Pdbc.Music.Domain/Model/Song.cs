using System;
using System.Collections.Generic;

namespace Pdbc.Music.Domain.Model
{
    public class Song :  BaseEntity, IModifiable //, IDuplicatable<Song>
    {

        public virtual String Title { get; set; }
        public virtual TimeSpan Duration { get; set; }
        public virtual Int32 Year { get; set; }

        public virtual Album Album { get; set; }
        public virtual IList<Genre> Genres { get; set; }
        public virtual IList<Artist> Artists { get; set; }
        public virtual IList<Playlist> Playlists { get; set; }

        public virtual FileInformation FileInformation { get; set; }
        
        #region Album Setter/Remover
        public virtual void SetAlbum(Album album)
        {
            Album = album;
            album?.Songs.Add(this);
        }

        public virtual void RemoveAlbum(Album album)
        {
            if (this.Album == album)
            {
                Album = null;
                album.Songs.Remove(this);
            }
        }
        #endregion

        #region Genres
        public virtual void SetGenres(IList<Genre> genres)
        {
            Genres = genres;
            foreach (var genre in genres)
            {
                genre.Songs.Add(this);
            }
        }
        public virtual void AddGenre(Genre genre)
        {
            Genres.Add(genre);
            genre.Songs.Add(this);
        }
        public virtual void RemoveGenre(Genre genre)
        {
            Genres.Remove(genre);
            genre.Songs.Remove(this);
        }
        #endregion

        #region Artists
        public virtual void SetArtists(IList<Artist> artists)
        {
            if (Artists != null)
            {
                foreach (var a in Artists)
                {
                    a.Songs.Remove(this);
                }
            }

            Artists = artists;
            foreach (var artist in artists)
            {
                artist.Songs.Add(this);
            }
        }

        public virtual void AddArtist(Artist artist)
        {
            Artists.Add(artist);
            artist.Songs.Add(this);
        }
        public virtual void RemoveArtist(Artist artist)
        {
            Artists.Remove(artist);
            artist.Songs.Remove(this);
        }
        #endregion


        public string ModifiedBy { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }
    }
}
