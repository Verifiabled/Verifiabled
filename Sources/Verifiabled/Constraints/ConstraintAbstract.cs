namespace Verifiabled.Constraints
{
    internal abstract class ConstraintAbstract<T> : IConstraint
    {
        public bool IsFulfilled { get; protected set; }

        public string? FailureMessage { get; }

        internal T Expected { get; }

        protected T Actual { get; }

        public ConstraintAbstract(T expected, T actual)
        {
            Expected = expected;
            Actual = actual;

            UpdateFulfillment();

            if (IsFulfilled)
                FailureMessage = FailureMessageHelper.FromExpectedAndActual(expected, actual);
        }

        protected abstract void UpdateFulfillment();
    }
}
