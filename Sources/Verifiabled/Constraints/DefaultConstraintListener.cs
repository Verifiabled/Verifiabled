namespace Verifiabled.Constraints
{
    internal sealed class DefaultConstraintListener : IConstraintListener
    {
        private List<Constraint> Constraints { get; } = new();

        public void Add(Constraint contraint)
            => Constraints.Add(contraint);

        public IEnumerable<Constraint> GetAllContraints()
            => Constraints;
    }
}
