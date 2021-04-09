using Pdbc.Music.Core.CQRS.Errors.Get;

namespace Pdbc.Music.UnitTest.Helpers.Core.CQRS.ErrorMessages
{
    public class GetErrorMessageQueryTestDataBuilder : GetErrorMessageQueryBuilder
    {
        public GetErrorMessageQueryTestDataBuilder()
        {
            Language = "NL";
            Key = "ERROR_KEY";
        }

    }
}