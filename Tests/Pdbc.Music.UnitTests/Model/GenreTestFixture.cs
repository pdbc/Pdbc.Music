using NUnit.Framework;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;
using Pdbc.Music.UnitTests.Base;

namespace Pdbc.Music.UnitTests.Model
{
    [TestFixture]
    public class GenreTestFixture : BaseSpecification
    {
        [Test]
        public void Verify_equals_return_false_with_two_different_objects()
        {
            var genre1 = new GenreTestDataBuilder().Build();
            var genre2 = new GenreTestDataBuilder().Build();

            genre1.Equals(genre2).ShouldBeFalse();

        }
    }
}
