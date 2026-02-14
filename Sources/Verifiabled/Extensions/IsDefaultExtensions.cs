using System.Diagnostics;
using Verifiabled.Constraints;
using Verifiabled.Exceptions;

namespace Verifiabled
{
    public static class IsDefaultExtensions
    {
        extension(Assert)
        {
            [StackTraceHidden]
            public static void IsDefault<TActual>(TActual actual)
                => AssertException.ThrowIfUnfulfilled(actual?.Equals(default) ?? true, FailureMessageHelper.FromExpectedAndActual(default(TActual), actual));
        }
    }
}
