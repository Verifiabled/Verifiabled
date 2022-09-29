namespace Verifiabled.Constraints
{
    internal sealed class IsDefaultConstraint<TActual> : IContraint
    {
        public bool IsFulfilled { get; }

        public string FailureMessage { get; }

        public IsDefaultConstraint(TActual actual)
        {
            FailureMessage = FailureMessageHelper.FromExpectedAndActual(default(TActual), actual);
            IsFulfilled = actual == null || actual.Equals(default(TActual));
        }
    }
}
