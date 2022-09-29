namespace Verifiabled.Constraints
{
    internal sealed class IsEqualConstraint<T> : ConstraintAbstract<T>
    {
        public IsEqualConstraint(T expected, T actual) : base(expected, actual)
        { }

        internal override void UpdateFulfillment()
            => IsFulfilled = Expected == null ? Actual == null : Expected.Equals(Actual);
    }
}
