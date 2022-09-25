namespace Verifiabled.Constraints
{
    public sealed class ContainsConstraint<TActual> : IContraint
    {
        public bool IsFulfilled { get; }

        public ContainsConstraint(TActual expected, IEnumerable<TActual> actual)
        {
            IsFulfilled = actual.Contains(expected);
        }
    }
}
