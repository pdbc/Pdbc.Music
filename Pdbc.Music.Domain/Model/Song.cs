using System;
using System.Collections.Generic;

namespace Pdbc.Music.Domain.Model
{
    public class Song :  AuditableIdentifiable, IModifiable
    {

        public virtual String Title { get; set; }
        public virtual TimeSpan Duration { get; set; }
        public virtual Int32 Year { get; set; }

        //public virtual Album Album { get; set; }
        //public virtual Int64? AlbumId { get; set; }

        public virtual IList<Genre> Genres { get; set; } = new List<Genre>();
        public virtual IList<Artist> Artists { get; set; } = new List<Artist>();

        public virtual FileInformation FileInformation { get; set; }
        public virtual Int64? FileInformationId { get; set; }

        
    }
}
