using System;
using System.Collections.Generic;

namespace Pdbc.Music.Domain.Model
{
    public class Album : BaseEntity<string>, IEquatable<Album>
    {
        public virtual IList<Song> Songs { get; set; }
        public virtual String Name { get; set; }

        public Album()
        {
            Songs = new List<Song>();
        }

        public Album(String name)
            : this()
        {
            Id = name.Trim().ToUpper();
            Name = name;
        }

        #region Equals
        public virtual bool Equals(Album other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Album)obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }

        public static bool operator ==(Album left, Album right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Album left, Album right)
        {
            return !Equals(left, right);
        }
        #endregion

    }
}