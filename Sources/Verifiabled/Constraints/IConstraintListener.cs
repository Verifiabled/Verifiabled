namespace Verifiabled.Constraints
{
    public interface IConstraintListener
    {
        void Broadcast(IConstraint contraint);
        IEnumerable<IConstraint> GetAllContraints();
        void Clear();
    }
}