using System.Diagnostics;
using System.Numerics;
using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class AreEqualNumericExtensions
    {
        extension(Assert)
        {
            [StackTraceHidden]
            public static void AreEqual<T>(T expected, T actual, T error) where T : INumber<T>
            {
                var absMeasuredError = T.Abs(expected > actual ? expected - actual : actual - expected);
                var isFulfilled = absMeasuredError <= T.Abs(error);
                GlobalConstraintListenerManager.Add(Constraint.Create(isFulfilled, FailureMessageHelper.FromExpectedAndActual(expected, actual)));
            }
        }
    }
}
