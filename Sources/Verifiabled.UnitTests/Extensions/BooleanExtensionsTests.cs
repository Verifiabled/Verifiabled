namespace Verifiabled.UnitTests.Extensions
{
    public sealed class BooleanExtensionsTests
    {
        [Case]
        public void ShouldPassWithTrue()
        {
            // arrange

            // act
            var actual = true;

            // assert
            Assert.That(actual).IsTrue();
        }

        [Case]
        public void ShouldPassWithFalse()
        {
            // arrange

            // act
            var actual = false;

            // assert
            Assert.That(actual).IsFalse();
        }
    }
}
