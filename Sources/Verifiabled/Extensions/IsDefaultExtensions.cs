using Verifiabled.Constraints;
using Verifiabled.Constructs;

namespace Verifiabled
{
    public static class IsDefaultExtensions
    {
        public static void IsDefault<TActual>(this IThatConstruct<TActual> thatConstruct)
        {
            var constraint = new IsDefaultConstraint<TActual>(thatConstruct.Actual);
            GlobalConstraintListenerManager.Broadcast(constraint);
        }
    }
}
