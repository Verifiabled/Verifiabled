namespace Verifiabled.Constraints
{
    internal sealed class IsEqualConstraint<T> : IContraint
    {
        public bool IsFulfilled { get; }

        public string FailureMessage { get; }

        public IsEqualConstraint(T expected, T actual)
        {
            FailureMessageHelper.FormMessageFromExpectedAndActual(expected.ToString(), actual.ToString());
            IsFulfilled = EqualityCheck(expected, actual);
        }

        private static bool EqualityCheck(T expected, T actual) => expected == null ? actual == null : expected.Equals(actual);
    }
}
