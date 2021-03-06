using System;
using System.Collections.Generic;

namespace Pdbc.Music.Domain.Model
{
    public class Genre : BaseEntity, IEquatable<Genre>
    {
        public virtual IList<Song> Songs { get; set; }
        public virtual String Name { get; set; }

        public Genre()
        {
            Songs = new List<Song>();
        }



        #region Equals
        public virtual bool Equals(Genre other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Name, other.Name);
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
            return (Name != null ? Name.GetHashCode() : 0);
        }

        public static bool operator ==(Genre left, Genre right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Genre left, Genre right)
        {
            return !Equals(left, right);
        }
        #endregion


    }
}