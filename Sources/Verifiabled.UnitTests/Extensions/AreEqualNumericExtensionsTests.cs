namespace Verifiabled.UnitTests.Extensions
{
    public sealed class AreEqualNumericExtensionsTests
    {
        //[Case]
        public void ShouldPassWithError()
        {
            // arrange
            int expected = 7;

            // act
            int actual = 9;

            // assert
            Assert.AreEqual(expected, actual, 2);
        }
    }
}
