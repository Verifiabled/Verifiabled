using System.Diagnostics;
using Verifiabled.Constraints;
using Verifiabled.Exceptions;

namespace Verifiabled
{
    public static class IsNullExtensions
    {
        extension(Assert)
        {
            [StackTraceHidden]
            public static void IsNull<TActual>(TActual? actual) where TActual : class
                => AssertException.ThrowIfUnfulfilled(actual == null, FailureMessageHelper.FromExpectedAndActual(null, actual));

            [StackTraceHidden]
            public static void IsNull(string? actual)
                => AssertException.ThrowIfUnfulfilled(actual == null, FailureMessageHelper.FromExpectedAndActual(null, actual));
        }
    }
}
