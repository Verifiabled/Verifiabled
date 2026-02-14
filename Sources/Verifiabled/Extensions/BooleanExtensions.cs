using System.Diagnostics;
using Verifiabled.Constraints;
using Verifiabled.Exceptions;

namespace Verifiabled
{
    public static class BooleanExtensions
    {
        extension(Assert)
        {
            [StackTraceHidden]
            public static void IsTrue(bool actual)
                => AssertException.ThrowIfUnfulfilled(actual == true, FailureMessageHelper.FromExpectedAndActual(true, actual));

            [StackTraceHidden]
            public static void IsFalse(bool actual)
                => AssertException.ThrowIfUnfulfilled(actual == false, FailureMessageHelper.FromExpectedAndActual(false, actual));
        }
    }
}
