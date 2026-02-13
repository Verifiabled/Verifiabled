using Verifiabled.Constraints;

namespace Verifiabled.UnitTests.Constraints
{
    public sealed class IsDefaultConstraintTests
    {
        [Case]
        public void ShouldBeFulfilled()
        {
            // arrange
            var actual = 0d;

            // act
            var constraint = new IsDefaultConstraint<double>(actual);

            // assert
            Assert.IsTrue(constraint.IsFulfilled);
        }

        [Case]
        public void ShouldBeUnfulfilled()
        {
            // arrange
            var actual = Math.Tau;

            // act
            var constraint = new IsDefaultConstraint<double>(actual);

            // assert
            Assert.IsFalse(constraint.IsFulfilled);
        }
    }
}
