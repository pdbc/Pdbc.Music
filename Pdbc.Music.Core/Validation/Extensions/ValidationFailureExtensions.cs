using FluentValidation.Results;
using Pdbc.Music.Common.Validation;

namespace Pdbc.Music.Core.Validation.Extensions
{
    public static class ValidationFailureExtensions
    {
        public static void AddErrorToValidationBag(this ValidationFailure failure, IValidationBag validationBag)
        {
            validationBag.AddError(failure.ErrorCode, failure.ErrorMessage);
        }
    }

    //public static class ValidationExtensions
    //{

    //}
}
