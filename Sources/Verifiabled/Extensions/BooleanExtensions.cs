using System.Diagnostics;
using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class BooleanExtensions
    {
        extension(Assert)
        {
            [StackTraceHidden]
            public static void IsTrue(bool actual)
                => GlobalConstraintListenerManager.Add(Constraint.Create(actual == true, FailureMessageHelper.FromExpectedAndActual(true, actual)));

            [StackTraceHidden]
            public static void IsFalse(bool actual)
                => GlobalConstraintListenerManager.Add(Constraint.Create(actual == false, FailureMessageHelper.FromExpectedAndActual(false, actual)));
        }
    }
}
