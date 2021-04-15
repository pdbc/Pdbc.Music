using FluentValidation;
using Pdbc.Music.Core.Validation;
using Pdbc.Music.I18N;

namespace Pdbc.Music.Core.CQRS.ErrorMessages.Get
{
    public class GetErrorMessageQueryValidator : FluentValidationValidator<GetErrorMessageQuery>, IValidationBagValidator<GetErrorMessageQuery>
    {
        public GetErrorMessageQueryValidator()
        {
            RuleFor(i => i.Language)
                .NotEmpty()
                .WithErrorCode(nameof(ErrorResources.LanguageNotEmpty));

            RuleFor(i => i.Key)
                .NotEmpty();
        }
    }
}