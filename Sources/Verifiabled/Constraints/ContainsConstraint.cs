namespace Verifiabled.Constraints
{
    public sealed class ContainsConstraint<TActual> : IContraint
    {
        public TActual Expected { get; }
        public IEnumerable<TActual> Actual { get; }

        public ContainsConstraint(TActual expected, IEnumerable<TActual> actual)
        {
            Expected = expected;
            Actual = actual;
        }

        public bool IsFulfilled => Actual.Contains(Expected);
    }
}
