using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Extensions;

namespace Pdbc.Music.UnitTest.Helpers.Domain.Model
{
    public class PlaylistTestDataBuilder : PlaylistBuilder
    {
        public PlaylistTestDataBuilder()
        {
            Name = UnitTestValueGenerator.GenerateRandomCode();
        }

    }
}