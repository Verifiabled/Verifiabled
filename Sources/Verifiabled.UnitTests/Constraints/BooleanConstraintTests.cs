using Verifiabled.Constraints;

namespace Verifiabled.UnitTests.Constraints
{
    public class BooleanConstraintTests
    {
        [Case]
        public void ShouldBeFulfilled()
        {
            // arrange
            var expected = true;
            var actual = true;

            // act
            var constraint = new BooleanConstraint(expected, actual);

            // assert
            Assert.IsTrue(constraint.IsFulfilled);
        }

        [Case]
        public void ShouldBeUnfulfilled()
        {
            // arrange
            var expected = true;
            var actual = false;

            // act
            var constraint = new BooleanConstraint(expected, actual);

            // assert
            Assert.IsFalse(constraint.IsFulfilled);
        }
    }
}
