using Verifiabled.Constraints;
using Verifiabled.Constraints.NumericConstraints;
using Verifiabled.Constructs;

namespace Verifiabled
{
    public static class IsEqualNumericExtensions
    {
        public static IsEqualByteConstraint IsEqual(this IThatConstruct<byte> thatConstruct, byte expected)
        {
            var constraint = new IsEqualByteConstraint(expected, thatConstruct.Actual);
            GlobalConstraintListenerManager.Broadcast(constraint);
            return constraint;
        }

        public static IsEqualByteConstraint WithinError(this IsEqualByteConstraint constraint, byte error)
        {
            constraint.Error = error;
            constraint.UpdateFulfillment();
            return constraint;
        }

        public static IsEqualByteConstraint WithinTolerance(this IsEqualByteConstraint constraint, decimal tolerance)
        {
            constraint.Error = (byte)(constraint.Expected * tolerance);
            constraint.UpdateFulfillment();
            return constraint;
        }
    }
}
