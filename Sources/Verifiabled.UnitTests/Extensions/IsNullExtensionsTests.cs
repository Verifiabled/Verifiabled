namespace Verifiabled.UnitTests.Extensions
{
    public sealed class IsNullExtensionsTests
    {
        //[Case]
        public void ShouldPassWithObject()
        {
            // arrange

            // act
            object? actual = null;

            // assert
            Assert.IsNull(actual);
        }

        //[Case]
        public void ShouldPassWithString()
        {
            // arrange

            // act
            string actual = null!;

            // assert
            Assert.IsNull(actual);
        }
    }
}
