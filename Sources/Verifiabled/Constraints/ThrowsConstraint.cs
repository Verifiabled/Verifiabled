namespace Verifiabled.Constraints
{
    internal static class ThrowsConstraint
    {
        internal static Constraint Create<TException>(Action act)
        {
            try
            {
                act();
                return Constraint.Fulfilled;
            }

            catch (Exception exception)
            {
                return Constraint.Create(exception is TException, FailureMessageHelper.FromExpectedAndActual(typeof(TException), exception));
            }
        }
    }
}
