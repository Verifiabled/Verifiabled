namespace Verifiabled.Constraints
{
    internal sealed class BooleanConstraint : ConstraintAbstract<bool>
    {
        public BooleanConstraint(bool expected, bool actual) : base(expected, actual)
        { }

        protected override void UpdateFulfillment()
            => IsFulfilled = Expected == Actual;
    }
}
