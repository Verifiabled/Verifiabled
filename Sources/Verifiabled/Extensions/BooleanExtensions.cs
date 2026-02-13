using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class BooleanExtensions
    {
        extension(Assert)
        {
            public static void IsTrue(bool actual)
            {
                var constraint = new BooleanConstraint(true, actual);
                GlobalConstraintListenerManager.Broadcast(constraint);
            }

            public static void IsFalse(bool actual)
            {
                var constraint = new BooleanConstraint(false, actual);
                GlobalConstraintListenerManager.Broadcast(constraint);
            }
        }
    }
}
