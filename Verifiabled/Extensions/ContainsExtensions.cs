using Verifiabled.Constructs;
using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class ContainsExtensions
    {
        public static void Contains<TActual>(this IThatIEnumerableConstruct<TActual> thatConstruct, TActual expected)
        {
            var constraint = new ContainsConstraint<TActual>(expected, thatConstruct.Actual);
            GlobalConstraintListenerManager.Broadcast(constraint);
        }
    }
}
