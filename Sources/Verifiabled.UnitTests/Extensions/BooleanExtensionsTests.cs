namespace Verifiabled.UnitTests.Extensions
{
    public sealed class BooleanExtensionsTests
    {
        //[Case]
        public void ShouldPassWithTrue()
        {
            // arrange

            // act
            var actual = true;

            // assert
            Assert.IsTrue(actual);
        }

        //[Case]
        public void ShouldPassWithFalse()
        {
            // arrange

            // act
            var actual = false;

            // assert
            Assert.IsFalse(actual);
        }
    }
}
