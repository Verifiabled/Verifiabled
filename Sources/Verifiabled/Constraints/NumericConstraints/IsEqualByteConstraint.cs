namespace Verifiabled.Constraints.NumericConstraints
{
    public sealed class IsEqualByteConstraint : ConstraintAbstract<byte>
    {
        internal byte Error { get; set; }

        public IsEqualByteConstraint(byte expected, byte actual) : base(expected, actual)
        { }

        internal override void UpdateFulfillment()
            => IsFulfilled = Math.Abs(Expected - Actual) <= Math.Abs(Error);
    }
}
