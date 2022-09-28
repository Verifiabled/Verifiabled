namespace Verifiabled.UnitTests.Extensions
{
    public sealed class ContainsExtensionsTests
    {
        [Case]
        public void ShouldPassWithIEnumerable()
        {
            // arrange

            // act
            var actual = Enumerable.Repeat(9, 1);

            // assert
            Assert.That(actual).Contains(9);
        }

        [Case]
        public void ShouldPassWithArray()
        {
            // arrange

            // act
            var actual = new[] { 9 };

            // assert
            Assert.That(actual).Contains(9);
        }
    }
}
