using Verifiabled.Constraints;

namespace Verifiabled.UnitTests.Constraints
{
    public sealed class IsEqualConstraintTests
    {
        [Case]
        public void ShouldBeFulfilled()
        {
            // arrange
            var expected = 0d;
            var actual = 0d;

            // act
            var constraint = new IsEqualConstraint<double>(expected, actual);

            // assert
            Assert.That(constraint.IsFulfilled).IsTrue();
        }

        [Case]
        public void ShouldBeFulfilledWithNull()
        {
            // arrange
            var expected = default(string);
            var actual = default(string);

            // act
            var constraint = new IsEqualConstraint<string?>(expected, actual);

            // assert
            Assert.That(constraint.IsFulfilled).IsTrue();
        }

        [Case]
        public void ShouldBeUnfulfilledWithNull()
        {
            // arrange
            var expected = default(string);
            var actual = string.Empty;

            // act
            var constraint = new IsEqualConstraint<string?>(expected, actual);

            // assert
            Assert.That(constraint.IsFulfilled).IsFalse();
        }
    }
}
