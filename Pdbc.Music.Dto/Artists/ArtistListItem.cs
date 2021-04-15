namespace Pdbc.Music.Dto.Artists
{
    /// <summary>
    /// Information about the application
    /// </summary>
    public interface IArtistListItem : IArtistInfo, IBaseIdentificationInfo
    {

    }

    /// <summary>
    /// Information about the application
    /// </summary>
    /// <seealso cref="IArtistInfo" />
    public class ArtistListItem : IArtistListItem
    {
        public long Id { get; set; }

        public string Name { get; set; }

    }
}