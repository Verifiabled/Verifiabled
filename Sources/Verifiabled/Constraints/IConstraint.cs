namespace Verifiabled.Constraints
{
    public interface IConstraint
    {
        bool IsFulfilled { get; }
        string FailureMessage { get; }
    }
}