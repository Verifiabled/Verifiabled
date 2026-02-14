using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class IsDefaultExtensions
    {
        extension(Assert)
        {
            public static void IsDefault<TActual>(TActual actual)
                => GlobalConstraintListenerManager.Add(Constraint.Create(actual?.Equals(default) ?? true, FailureMessageHelper.FromExpectedAndActual(default(TActual), actual)));
        }
    }
}
