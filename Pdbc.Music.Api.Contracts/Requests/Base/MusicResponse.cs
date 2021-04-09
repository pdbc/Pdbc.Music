using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Pdbc.Music.Api.Contracts.Requests
{
    /// <summary>
    /// A response coming from the PDBC.Music API
    /// </summary>
    public interface IMusicResponse
    {
        /// <summary>
        /// information about the success of the request
        /// </summary>
        ValidationResult Notifications { get; set; }
    }

    /// <inheritdoc />
    public class MusicResponse : IMusicResponse
    {
        /// <inheritdoc />
        public ValidationResult Notifications { get; set; }
    }


    /// <summary>
    /// DataContract type to transfer a Validation Result containing multiple Validation Messages (e.g. from ValconBag).
    /// </summary>
    public class ValidationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult"/> class.
        /// </summary>
        public ValidationResult()
        {
            Messages = new List<ValidationResultMessage>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult"/> class.
        /// </summary>
        public ValidationResult(IEnumerable<ValidationResultMessage> messages)
        {
            Messages = messages;
        }

        /// <summary>
        /// The Validation Messages included in this Validation Result.
        /// </summary>

        public IEnumerable<ValidationResultMessage> Messages { get; set; }

        /// <summary>
        /// Flag to indicate if this Validation Result contains any Error messages.
        /// </summary>
        /// <returns></returns>
        public bool HasErrors()
        {
            return Messages.Any();
        }
    }

    /// <summary>
    /// Data contract to signal a message of the validation result
    /// </summary>
    public class ValidationResultMessage
    {
        /// <summary>
        /// The Error code of the validation message
        /// </summary>
        public String Key { get; set; }

        /// <summary>
        /// The message of the validation error
        /// </summary>
        public String Message { get; set; }
    }

}