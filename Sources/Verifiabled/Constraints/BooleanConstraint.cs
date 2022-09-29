namespace Verifiabled.Constraints
{
    internal sealed class BooleanConstraint : ConstraintAbstract<bool>
    {
        public BooleanConstraint(bool expected, bool actual) : base(expected, actual)
        { }

        internal override void UpdateFulfillment()
            => IsFulfilled = Expected == Actual;
    }
}
