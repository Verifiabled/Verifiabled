using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class BooleanExtensions
    {
        extension(Assert)
        {
            public static void IsTrue(bool actual)
                => GlobalConstraintListenerManager.Add(Constraint.Create(actual == true, FailureMessageHelper.FromExpectedAndActual(true, actual)));

            public static void IsFalse(bool actual)
                => GlobalConstraintListenerManager.Add(Constraint.Create(actual == false, FailureMessageHelper.FromExpectedAndActual(false, actual)));
        }
    }
}
