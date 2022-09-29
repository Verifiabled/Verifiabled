namespace Verifiabled.Constraints
{
    internal sealed class BooleanConstraint : IContraint
    {
        public bool IsFulfilled { get; }

        public string FailureMessage { get; }

        public BooleanConstraint(bool expected, bool actual)
        {
            FailureMessage = FailureMessageHelper.FromExpectedAndActual(expected, actual);
            IsFulfilled = expected == actual;
        }
    }
}
