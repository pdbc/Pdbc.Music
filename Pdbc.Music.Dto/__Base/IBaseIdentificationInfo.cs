namespace Pdbc.Music.Dto
{
    /// <summary>
    /// Marker interface for identifying an object
    /// </summary>
    public interface IBaseIdentificationInfo
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        long Id { get; set; }
    }
}