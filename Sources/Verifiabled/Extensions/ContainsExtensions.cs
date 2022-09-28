using Verifiabled.Constructs;
using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class ContainsExtensions
    {
        public static void Contains<T>(this IThatConstruct<IEnumerable<T>> thatConstruct, T expected)
        {
            var constraint = new ContainsConstraint<T>(expected, thatConstruct.Actual);
            GlobalConstraintListenerManager.Broadcast(constraint);
        }

        public static void Contains<T>(this IThatConstruct<T[]> thatConstruct, T expected)
        {
            var constraint = new ContainsConstraint<T>(expected, thatConstruct.Actual);
            GlobalConstraintListenerManager.Broadcast(constraint);
        }
    }
}
