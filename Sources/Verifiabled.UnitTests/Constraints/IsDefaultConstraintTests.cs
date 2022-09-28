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
            Assert.That(constraint.IsFulfilled).IsTrue();
        }

        [Case]
        public void ShouldBeUnfulfilled()
        {
            // arrange
            var actual = Math.Tau;

            // act
            var constraint = new IsDefaultConstraint<double>(actual);

            // assert
            Assert.That(constraint.IsFulfilled).IsFalse();
        }
    }
}
