namespace Verifiabled.Constraints
{
    internal sealed class IsDefaultConstraint<TActual> : ConstraintAbstract<TActual>
    {
        public IsDefaultConstraint(TActual actual) : base(default!, actual)
        { }

        protected override void UpdateFulfillment()
             => IsFulfilled = Actual == null || Actual.Equals(Expected);
    }
}
