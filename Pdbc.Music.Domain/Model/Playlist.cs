using System;
using System.Collections.Generic;

namespace Pdbc.Music.Domain.Model
{
    public class Playlist : BaseEntity, IEquatable<Playlist>
    {
        public virtual String Name { get; set; }
        public virtual IList<Song> Songs { get; set; }

        public Playlist()
        {
            Songs = new List<Song>();

        }

        public Playlist(String name)
            : this()
        {
            Name = name;
        }

        //#region Song Setter/Remover
        //public virtual void AddSong(Song song)
        //{
        //    Songs.Add(song);
        //}

        //public virtual void RemoveSong(Song song)
        //{
        //    Songs.Remove(song);
        //}
        //#endregion

        public override string ToString()
        {
            return Name;
        }

        #region Equals
        public virtual bool Equals(Playlist other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Genre)obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }

        public static bool operator ==(Playlist left, Playlist right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Playlist left, Playlist right)
        {
            return !Equals(left, right);
        }
        #endregion
    }
}