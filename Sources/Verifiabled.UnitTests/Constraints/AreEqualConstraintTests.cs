using Verifiabled.Constraints;

namespace Verifiabled.UnitTests.Constraints
{
    public sealed class AreEqualConstraintTests
    {
        [Case]
        public void ShouldBeFulfilled()
        {
            // arrange
            var expected = 0d;
            var actual = 0d;

            // act
            var constraint = new AreEqualConstraint<double>(expected, actual);

            // assert
            Assert.IsTrue(constraint.IsFulfilled);
        }

        [Case]
        public void ShouldBeFulfilledWithNull()
        {
            // arrange
            var expected = default(string);
            var actual = default(string);

            // act
            var constraint = new AreEqualConstraint<string?>(expected, actual);

            // assert
            Assert.IsTrue(constraint.IsFulfilled);
        }

        [Case]
        public void ShouldBeUnfulfilledWithNull()
        {
            // arrange
            var expected = default(string);
            var actual = string.Empty;

            // act
            var constraint = new AreEqualConstraint<string?>(expected, actual);

            // assert
            Assert.IsFalse(constraint.IsFulfilled);
        }
    }
}
