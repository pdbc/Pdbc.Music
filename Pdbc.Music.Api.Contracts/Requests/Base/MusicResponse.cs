using System.ComponentModel.DataAnnotations;

namespace Pdbc.Music.Api.Contracts.Requests
{
    /// <summary>
    /// A response coming from the PDBC.Music API
    /// </summary>
    public interface IMusicResponse
    {
        ///// <summary>
        ///// information about the success of the request
        ///// </summary>
        ////ValidationResult Notifications { get; set; }
    }

    /// <inheritdoc />
    public class MusicResponse : IMusicResponse
    {
        ///// <inheritdoc />
        //public ValidationResult Notifications { get; set; }
    }
}