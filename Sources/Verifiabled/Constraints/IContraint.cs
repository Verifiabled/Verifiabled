namespace Verifiabled.Constraints
{
    public interface IContraint
    {
        bool IsFulfilled { get; }
        string FailureMessage { get; }
    }
}