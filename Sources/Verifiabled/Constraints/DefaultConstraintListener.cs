namespace Verifiabled.Constraints
{
    internal sealed class DefaultConstraintListener : IConstraintListener
    {
        private List<IConstraint> Constraints { get; } = new();

        public void Broadcast(IConstraint contraint) => Constraints.Add(contraint);

        public IEnumerable<IConstraint> GetAllContraints() => Constraints;

        public void Clear() => Constraints.Clear();
    }
}
