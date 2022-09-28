namespace Verifiabled.UnitTests.Extensions
{
    public sealed class ThrowsExtensionsTests
    {
        [Case]
        public void ShouldPass()
        {
            // arrange

            // act
            static void Act() => throw new NotImplementedException();

            // assert
            Assert.That(Act).Throws<NotImplementedException>();
        }
    }
}
