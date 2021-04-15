using System;

namespace Pdbc.Music.Dto.Artists
{
    public interface IUpdateArtist : IArtistInfo, IBaseUpdateInfo
    {

    }


    public class UpdateArtist : IUpdateArtist
    {
        public long Id { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }

        public string Name { get; set; }

    }
}