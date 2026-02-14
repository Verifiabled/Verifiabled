using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class IsNullExtensions
    {
        extension(Assert)
        {
            public static void IsNull<TActual>(TActual? actual) where TActual : class
                => GlobalConstraintListenerManager.Add(Constraint.Create(actual == null, FailureMessageHelper.FromExpectedAndActual(null, actual)));

            public static void IsNull(string? actual)
                => GlobalConstraintListenerManager.Add(Constraint.Create(actual == null, FailureMessageHelper.FromExpectedAndActual(null, actual)));
        }
    }
}
