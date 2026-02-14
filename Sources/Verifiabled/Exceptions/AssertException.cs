namespace Verifiabled.Exceptions
{
    internal sealed class AssertException : Exception
    {
        internal AssertException(string message) : base(message)
        { }

        internal static void ThrowIfUnfulfilled(bool condition, string? message)
        {
            if (!condition)
                throw new AssertException(message ?? "Assertion failed");
        }
    }
}
