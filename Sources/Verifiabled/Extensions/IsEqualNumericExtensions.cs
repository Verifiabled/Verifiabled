using System.Numerics;
using Verifiabled.Constraints;
using Verifiabled.Constraints.NumericConstraints;
using Verifiabled.Constructs;

namespace Verifiabled
{
    public static class IsEqualNumericExtensions
    {
        public static IsEqualNumericConstraint<T> IsEqualNumeric<T>(this IThatConstruct<T> thatConstruct, T expected) where T : INumber<T>
        {
            var constraint = new IsEqualNumericConstraint<T>(expected, thatConstruct.Actual);
            GlobalConstraintListenerManager.Broadcast(constraint);
            return constraint;
        }

        public static IsEqualNumericConstraint<T> WithinError<T>(this IsEqualNumericConstraint<T> constraint, T error) where T : INumber<T>
        {
            constraint.Error = error;
            constraint.UpdateFulfillment();
            return constraint;
        }

        public static IsEqualNumericConstraint<T> WithinTolerance<T>(this IsEqualNumericConstraint<T> constraint, decimal tolerance) where T : INumber<T>
        {
            constraint.Error = T.CreateTruncating(decimal.CreateTruncating(constraint.Expected) * Math.Abs(tolerance));
            constraint.UpdateFulfillment();
            return constraint;
        }
    }
}
