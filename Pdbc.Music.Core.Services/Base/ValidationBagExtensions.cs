using Pdbc.Music.Api.Contracts.Requests;
using Pdbc.Music.Common.Validation;
using System.Collections.Generic;

namespace Pdbc.Music.Core.Services
{
    /// <summary>
    /// Extension methods for mapping <see cref="ValidationBag"/> to the <see cref="ValidationResult"/> data contract and vice-versa.
    /// </summary>
    public static class ValidationBagExtensions
    {

        /// <summary>
        /// Maps the <see cref="ValidationBag"/> to a corresponding <see cref="ValidationResult"/>.
        /// </summary>
        /// <param name="validationBag"></param>
        /// <returns></returns>
        public static ValidationResult ToValidationResult(this ValidationBag validationBag)
        {
            var messages = new List<ValidationResultMessage>();
            foreach (var msg in validationBag.ErrorMessages)
            {
                var item = new ValidationResultMessage()
                {
                    Key = msg.Key,
                    Message = msg.Message
                };
                messages.Add(item);
            }
            var validationResult = new ValidationResult(messages);

            return validationResult;

        }
    }
}