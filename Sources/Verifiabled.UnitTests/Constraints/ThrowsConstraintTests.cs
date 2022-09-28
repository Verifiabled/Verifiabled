using Verifiabled.Constraints;

namespace Verifiabled.UnitTests.Constraints
{
    public sealed class ThrowsConstraintTests
    {
        [Case]
        public void ShouldBeFulfilled()
        {
            // arrange
            static void Act() => throw new NotImplementedException();

            // act
            var constraint = new ThrowsConstraint<NotImplementedException>(Act);

            // assert
            Assert.That(constraint.IsFulfilled).IsTrue();
        }

        [Case]
        public void ShouldBeUnfulfilled()
        {
            // arrange
            static void Act() => throw new NotImplementedException();

            // act
            var constraint = new ThrowsConstraint<InvalidOperationException>(Act);

            // assert
            Assert.That(constraint.IsFulfilled).IsFalse();
        }
    }
}
