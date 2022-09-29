namespace Verifiabled.UnitTests.Extensions
{
    public sealed class IsEqualExtensionsTests
    {
        [Case]
        public void ShouldPassWithDouble()
        {
            // arrange
            var expected = 9d;

            // act
            var actual = 9d;

            // assert
            Assert.That(actual).IsEqual(expected);
        }
    }
}
