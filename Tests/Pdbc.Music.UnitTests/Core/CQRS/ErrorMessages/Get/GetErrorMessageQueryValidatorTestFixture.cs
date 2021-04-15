using NUnit.Framework;
using Pdbc.Music.Common.Validation;
using Pdbc.Music.Core.CQRS.ErrorMessages.Get;
using Pdbc.Music.I18N;
using Pdbc.Music.UnitTest.Helpers.Base;
using Pdbc.Music.UnitTest.Helpers.Core.CQRS.ErrorMessages;
using Pdbc.Music.UnitTests.Base;
using System.Linq;

namespace Pdbc.Music.UnitTests.Core.CQRS.ErrorMessages.Get
{
    public class GetErrorMessageQueryValidatorTestFixture : ContextSpecification<GetErrorMessageQueryValidator>
    {
        [Test]
        public void Verify_error_when_language_is_null()
        {
            var query = new GetErrorMessageQueryTestDataBuilder()
                                .WithLanguage(null);

            var validationResult = SUT.Validate(query);

            validationResult.IsValid.ShouldBeFalse();
            validationResult.Errors.Count.ShouldBeEqualTo(1);
            validationResult.Errors.Any(x => x.ErrorCode == nameof(ErrorResources.LanguageNotEmpty)).ShouldBeTrue();
        }


        [Test]
        public void Verify_error_when_language_is_null_with_validation_bag()
        {
            var validationBag = new ValidationBag();
            var query = new GetErrorMessageQueryTestDataBuilder()
                .WithLanguage(null);

            SUT.Validate(query, validationBag)
                .GetAwaiter()
                .GetResult();

            validationBag.HasErrors().ShouldBeTrue();
            validationBag.ErrorMessages.Count.ShouldBeEqualTo(1);
            validationBag.ErrorMessages.Any(x => x.Key == nameof(ErrorResources.LanguageNotEmpty)).ShouldBeTrue();
        }
    }
}
