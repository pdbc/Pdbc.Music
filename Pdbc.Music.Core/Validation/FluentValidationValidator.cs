using FluentValidation;
using FluentValidation.Results;
using Pdbc.Music.Common.Validation;
using Pdbc.Music.Core.Validation.Extensions;
using System.Threading.Tasks;

namespace Pdbc.Music.Core.Validation
{
    public interface IValidationBagValidator<in T> : IValidator<T>
    {
        Task Validate(T instance, ValidationBag bag);
    }

    /// <summary>
    /// Fluent Validator implementation and map errors to scoped ValidationBag
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class FluentValidationValidator<T> : AbstractValidator<T>, IValidationBagValidator<T>
    {
        public Task Validate(T instance, ValidationBag bag)
        {
            ValidationResult result = base.Validate(instance);

            foreach (ValidationFailure error in result.Errors)
            {
                error.AddErrorToValidationBag(bag);
            }
            return Task.CompletedTask;
        }
    }
}
