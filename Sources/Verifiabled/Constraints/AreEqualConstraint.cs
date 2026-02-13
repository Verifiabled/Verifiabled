namespace Verifiabled.Constraints
{
    internal sealed class AreEqualConstraint<T> : ConstraintAbstract<T>
    {
        public AreEqualConstraint(T expected, T actual) : base(expected, actual)
        { }

        internal override void UpdateFulfillment()
            => IsFulfilled = Expected == null ? Actual == null : Expected.Equals(Actual);
    }
}
