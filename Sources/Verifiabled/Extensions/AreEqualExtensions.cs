using System.Diagnostics;
using Verifiabled.Constraints;
using Verifiabled.Exceptions;

namespace Verifiabled
{
    public static class AreEqualExtensions
    {
        extension(Assert)
        {
            [StackTraceHidden]
            public static void AreEqual<T>(T expected, T actual)
                => AssertException.ThrowIfUnfulfilled(expected == null ? actual == null : expected.Equals(actual), FailureMessageHelper.FromExpectedAndActual(expected, actual));
        }
    }
}
