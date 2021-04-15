using System;

namespace Pdbc.Music.Dto
{
    /// <summary>
    /// Marker interface for defining the properties required to perform an update
    /// </summary>
    /// <seealso cref="IBaseIdentificationInfo" />
    public interface IBaseUpdateInfo : IBaseIdentificationInfo
    {
        /// <summary>
        /// Gets or sets the modified on, this is the version date used for optimistic locking.
        /// </summary>
        /// <value>
        /// The modified on.
        /// </value>
        DateTimeOffset ModifiedOn { get; set; }
    }
}
