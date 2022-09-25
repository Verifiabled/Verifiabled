namespace Verifiabled.Constraints
{
    internal sealed class DefaultConstraintListener : IConstraintListener
    {
        private List<IContraint> Constraints { get; } = new();

        public void Broadcast(IContraint contraint) => Constraints.Add(contraint);

        public IEnumerable<IContraint> GetAllContraints() => Constraints;

        public void Clear() => Constraints.Clear();
    }
}
