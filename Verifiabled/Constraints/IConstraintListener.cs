namespace Verifiabled.Constraints
{
    public interface IConstraintListener
    {
        void Broadcast(IContraint contraint);
        IEnumerable<IContraint> GetAllContraints();
        void Clear();
    }
}