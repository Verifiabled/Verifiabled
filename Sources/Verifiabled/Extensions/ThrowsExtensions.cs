using Verifiabled.Constraints;
using Verifiabled.Constructs;

namespace Verifiabled
{
    public static class ThrowsExtensions
    {
        public static void Throws<TException>(this IThatConstruct<Action> thatConstruct) where TException : Exception
        {
            var constraint = new ThrowsConstraint<TException>(thatConstruct.Actual);
            GlobalConstraintListenerManager.Broadcast(constraint);
        }
    }
}
