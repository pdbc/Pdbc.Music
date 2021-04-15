namespace Pdbc.Music.Dto.Artists
{
    /// <summary>
    /// Information about the artist
    /// </summary>
    public interface IArtistInfo
    {
        /// <summary>
        /// Gets or sets the name of the artist.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; set; }
    }

    /// <summary>
    /// Information about the artist
    /// </summary>
    /// <seealso cref="IArtistInfo" />
    public class ArtistInfo : IArtistInfo
    {
        /// <inheritdoc />
        public string Name { get; set; }
    }
}
