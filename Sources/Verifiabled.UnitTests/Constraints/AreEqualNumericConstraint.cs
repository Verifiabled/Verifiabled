using Verifiabled.Constraints;
using Verifiabled.Constraints.NumericConstraints;

namespace Verifiabled.UnitTests.Constraints
{
    public sealed class AreEqualNumericConstraintTests
    {
        [Case]
        public void ShouldBeFulfilled()
        {
            // arrange
            var expected = 0d;
            var actual = 0d;

            // act
            var constraint = new AreEqualNumericConstraint<double>(expected, actual, 0d);

            // assert
            Assert.IsTrue(constraint.IsFulfilled);
        }

        [Case]
        public void ShouldBeFulfilledWithError()
        {
            // arrange
            var expected = 0d;
            var actual = 0.5d;

            // act
            var constraint = new AreEqualNumericConstraint<double>(expected, actual, 0.5d);

            // assert
            Assert.IsTrue(constraint.IsFulfilled);
        }

        [Case]
        public void ShouldBeRejectedWithError()
        {
            // arrange
            var expected = 0d;
            var actual = 0.5d;

            // act
            var constraint = new AreEqualNumericConstraint<double>(expected, actual, 0.4d);

            // assert
            Assert.IsFalse(constraint.IsFulfilled);
        }

        [Case]
        public void ShouldBeFulfilledWithNegativeError()
        {
            // arrange
            var expected = 0d;
            var actual = 0.5d;
            // act
            var constraint = new AreEqualNumericConstraint<double>(expected, actual, -0.5d);
            // assert
            Assert.IsTrue(constraint.IsFulfilled);
        }

        [Case]
        public void ShouldBeRejectedWithNegativeError()
        {
            // arrange
            var expected = 0d;
            var actual = 0.5d;

            // act
            var constraint = new AreEqualNumericConstraint<double>(expected, actual, -0.4d);

            // assert
            Assert.IsFalse(constraint.IsFulfilled);
        }

        [Case]
        public void ShouldBeFulfilledWithUnsignedNumbers()
        {
            // arrange
            var expected = 1UL;
            var actual = 100UL;
            // act
            var constraint = new AreEqualNumericConstraint<double>(expected, actual, 99d);
            // assert
            Assert.IsTrue(constraint.IsFulfilled);
        }

        [Case]
        public void ShouldBeFulfilledWithUnsignedNumbersInverted()
        {
            // arrange
            var expected = 100UL;
            var actual = 1UL;
            // act
            var constraint = new AreEqualNumericConstraint<double>(expected, actual, 99d);
            // assert
            Assert.IsTrue(constraint.IsFulfilled);
        }
    }
}
