using System.Diagnostics;
using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class AreEqualExtensions
    {
        extension(Assert)
        {
            [StackTraceHidden]
            public static void AreEqual<T>(T expected, T actual)
                => GlobalConstraintListenerManager.Add(Constraint.Create(expected == null ? actual == null : expected.Equals(actual), FailureMessageHelper.FromExpectedAndActual(expected, actual)));
        }
    }
}
