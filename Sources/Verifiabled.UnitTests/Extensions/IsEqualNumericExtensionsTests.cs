namespace Verifiabled.UnitTests.Extensions
{
    public sealed class IsEqualNumericExtensionsTests
    {
        [Case]
        public void ShouldPassWithError()
        {
            // arrange
            byte expected = 7;

            // act
            byte actual = 9;

            // assert
            Assert.That(actual).IsEqual(expected).WithinError(2);
        }

        [Case]
        public void ShouldPassWithTolerance()
        {
            // arrange
            byte expected = 7;

            // act
            byte actual = 9;

            // assert
            Assert.That(actual).IsEqual(expected).WithinTolerance(0.3m);
        }
    }
}
