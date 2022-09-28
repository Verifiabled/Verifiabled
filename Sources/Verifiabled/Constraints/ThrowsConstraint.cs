namespace Verifiabled.Constraints
{
    internal sealed class ThrowsConstraint<TException> : IContraint where TException : Exception
    {
        public bool IsFulfilled { get; }

        public string FailureMessage { get; }

        public ThrowsConstraint(Action act)
        {
            try
            {
                FailureMessage = string.Empty;
                act();
            }

            catch (Exception exception)
            {
                FailureMessage = FailureMessageHelper.FormMessageFromExpectedAndActual(typeof(TException).Name, exception.GetType().Name);
                IsFulfilled = exception is TException;
            }
        }
    }
}
