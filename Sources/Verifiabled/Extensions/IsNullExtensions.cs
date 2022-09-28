using Verifiabled.Constraints;
using Verifiabled.Constructs;

namespace Verifiabled
{
    public static class IsNullExtensions
    {
        public static void IsNull<TActual>(this IThatConstruct<TActual> thatConstruct) where TActual : class
        {
            var constraint = new IsDefaultConstraint<TActual>(thatConstruct.Actual);
            GlobalConstraintListenerManager.Broadcast(constraint);
        }

        public static void IsNull(this IThatConstruct<string> thatConstruct)
        {
            var constraint = new IsDefaultConstraint<string>(thatConstruct.Actual);
            GlobalConstraintListenerManager.Broadcast(constraint);
        }
    }
}
