using Verifiabled.Constraints;
using Verifiabled.Constructs;

namespace Verifiabled
{
    public static class IsEqualExtensions
    {
        public static void IsEqual<TActual>(this IThatConstruct<TActual> thatConstruct, TActual expected)
        {
            var constraint = new IsEqualConstraint<TActual>(expected, thatConstruct.Actual);
            GlobalConstraintListenerManager.Broadcast(constraint);
        }
    }
}
