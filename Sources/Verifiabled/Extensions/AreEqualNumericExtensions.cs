using System.Numerics;
using Verifiabled.Constraints;
using Verifiabled.Constraints.NumericConstraints;

namespace Verifiabled
{
    public static class AreEqualNumericExtensions
    {
        extension(Assert)
        {
            public static void AreEqual<T>(T expected, T actual, T error) where T : INumber<T>
            {
                var constraint = new AreEqualNumericConstraint<T>(expected, actual, error);
                GlobalConstraintListenerManager.Broadcast(constraint);
            }
        }
    }
}
