namespace Verifiabled.Constraints
{
    internal sealed class ThrowsConstraint<TException> : IConstraint where TException : Exception
    {
        public bool IsFulfilled { get; }

        public string? FailureMessage { get; }

        public ThrowsConstraint(Action act)
        {
            try
            {
                act();
            }

            catch (Exception exception)
            {
                IsFulfilled = exception is TException;

                if (IsFulfilled)
                    FailureMessage = FailureMessageHelper.FromExpectedAndActual(typeof(TException), exception);
            }
        }
    }
}
