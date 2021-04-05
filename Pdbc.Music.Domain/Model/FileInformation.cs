using System;
using System.IO;

namespace Pdbc.Music.Domain.Model
{
    public class FileInformation : BaseEntity
    {
        public virtual String CurrentFullPath { get; set; }

        public virtual String Filename { get; set; }
        public virtual String Directory { get; set; }
        public virtual String Extension { get; set; }
        public virtual Song Song { get; set; }
        public virtual Int64 SongId { get; set; }

        public virtual void SetValuesFromPath(String path)
        {
            CurrentFullPath = path;

            Directory = Path.GetDirectoryName(path);
            Filename = Path.GetFileNameWithoutExtension(path);
            Extension = Path.GetExtension(path);
        }

        public virtual string CalculateFullPath()
        {
            return $"{Path.Combine(Directory, Filename)}{Extension}";
        }

        public virtual Boolean HasValidFilename()
        {
            var parts = Filename.Split('-');
            return parts.Length == 2;
        }

        public virtual String GetArtistPart()
        {
            var parts = Filename.Split('-');
            if (parts.Length == 2)
            {
                return parts[0].Trim();
            }
            return String.Empty;
        }
        public virtual String GetTitlePart()
        {
            var parts = Filename.Split('-');
            if (parts.Length == 2)
            {
                return parts[1].Trim();
            }
            return String.Empty;
        }
    }
}