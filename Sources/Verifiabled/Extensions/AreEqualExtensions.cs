using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class AreEqualExtensions
    {
        extension(Assert)
        {
            public static void AreEqual<T>(T expected, T actual)
            {
                var constraint = new AreEqualConstraint<T>(expected, actual);
                GlobalConstraintListenerManager.Broadcast(constraint);
            }
        }
    }
}
