namespace Verifiabled.Constraints
{
    public sealed class ContainsConstraint<TActual> : IContraint
    {
        public bool IsFulfilled { get; }

        public string FailureMessage { get; }

        public ContainsConstraint(TActual expected, IEnumerable<TActual> actual)
        {
            FailureMessage = $"Expected haystack to contain needle.\nHaystack: {actual}\nNeedle: {expected}"; // TODO move this away from here
            IsFulfilled = actual.Contains(expected);
        }
    }
}
