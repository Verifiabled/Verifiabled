using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class ThrowsExtensions
    {
        extension(Assert)
        {
            public static void Throws<TException>(Action act) where TException : Exception
            {
                var constraint = new ThrowsConstraint<TException>(act);
                GlobalConstraintListenerManager.Broadcast(constraint);
            }
        }
    }
}
