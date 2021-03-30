using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Extensions;

namespace Pdbc.Music.UnitTest.Helpers.Domain.Model
{
    public class GenreTestDataBuilder : GenreBuilder
    {
        public GenreTestDataBuilder()
        {
            Name = UnitTestValueGenerator.GenerateRandomCode();
        }

    }
}
