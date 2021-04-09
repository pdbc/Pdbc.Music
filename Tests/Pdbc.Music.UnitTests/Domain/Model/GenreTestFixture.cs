using NUnit.Framework;
using Pdbc.Music.UnitTest.Helpers.Base;
using Pdbc.Music.UnitTest.Helpers.Domain.Model;
using Pdbc.Music.UnitTests.Base;

namespace Pdbc.Music.UnitTests.Domain.Model
{
    [TestFixture]
    public class GenreTestFixture : BaseSpecification
    {
        [Test]
        public void Verify_equals_return_false_with_two_different_objects()
        {
            var genre1 = new GenreTestDataBuilder()
                .Build();
            var genre2 = new GenreTestDataBuilder()
                .Build();

            genre1.Equals(genre2).ShouldBeFalse();
        }

        [Test]
        public void Verify_equals_return_true_when_name_matches()
        {
            var genre1 = new GenreTestDataBuilder()
                .Build();
            var genre2 = new GenreTestDataBuilder()
                .WithName(genre1.Name)
                .Build();

            genre1.Equals(genre2).ShouldBeTrue();
        }
    }
}
