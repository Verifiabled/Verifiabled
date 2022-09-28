using Verifiabled.Constraints;
using Verifiabled.Constructs;

namespace Verifiabled
{
    public static class BooleanExtensions
    {
        public static void IsTrue(this IThatConstruct<bool> thatConstruct)
        {
            var constraint = new BooleanConstraint(true, thatConstruct.Actual);
            GlobalConstraintListenerManager.Broadcast(constraint);
        }

        public static void IsFalse(this IThatConstruct<bool> thatConstruct)
        {
            var constraint = new BooleanConstraint(false, thatConstruct.Actual);
            GlobalConstraintListenerManager.Broadcast(constraint);
        }
    }
}
