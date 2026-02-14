namespace Verifiabled.UnitTests.Extensions
{
    public sealed class AreEqualExtensionsTests
    {
        //[Case]
        public void ShouldPassWithDouble()
        {
            // arrange
            var expected = 9d;

            // act
            var actual = 9d;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
