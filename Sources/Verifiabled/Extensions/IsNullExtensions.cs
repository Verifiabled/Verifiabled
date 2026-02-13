using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class IsNullExtensions
    {
        extension(Assert)
        {
            public static void IsNull<TActual>(TActual actual) where TActual : class
            {
                var constraint = new IsDefaultConstraint<TActual>(actual);
                GlobalConstraintListenerManager.Broadcast(constraint);
            }

            public static void IsNull(string actual)
            {
                var constraint = new IsDefaultConstraint<string>(actual);
                GlobalConstraintListenerManager.Broadcast(constraint);
            }
        }
    }
}
