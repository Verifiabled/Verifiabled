namespace Verifiabled.Constraints
{
    public interface IConstraintListener
    {
        void Add(Constraint contraint);
        IEnumerable<Constraint> GetAllContraints();
    }
}