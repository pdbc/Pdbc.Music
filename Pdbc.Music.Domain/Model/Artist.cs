using System;
using System.Collections.Generic;

namespace Pdbc.Music.Domain.Model
{
    public class Artist : BaseEntity, IEquatable<Artist> //, IDuplicatable<Artist>
    {
        public virtual IList<Song> Songs { get; set; }
        public virtual String Name { get; set; }

        //public virtual bool IsDuplicate { get; set; }
        
        public Artist()
        {
            Songs = new List<Song>();
        }

        #region Equals
        public virtual bool Equals(Artist other)
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
            return Equals((Artist)obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }

        public static bool operator ==(Artist left, Artist right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Artist left, Artist right)
        {
            return !Equals(left, right);
        }
        #endregion

    }
}