namespace Verifiabled.UnitTests.Extensions
{
    public sealed class IsDefaultExtensionsTests
    {
        [Case]
        public void ShouldPass()
        {
            // arrange

            // act
            double actual = 0d;

            // assert
            Assert.That(actual).IsDefault();
        }
    }
}
