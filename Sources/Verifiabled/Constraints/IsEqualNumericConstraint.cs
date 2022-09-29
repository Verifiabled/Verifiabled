using System.Numerics;

namespace Verifiabled.Constraints.NumericConstraints
{
    public sealed class IsEqualNumericConstraint<T> : ConstraintAbstract<T> where T : INumber<T>
    {
        internal T Error { get; set; }

        public IsEqualNumericConstraint(T expected, T actual) : base(expected, actual)
        { }

        internal override void UpdateFulfillment()
        {
            var absExpectedError = T.Abs(Error);
            var absMeasuredError = Expected > Actual ? Expected - Actual : Actual - Expected; // this logic is needed for unsigned types
            IsFulfilled = absMeasuredError <= absExpectedError;
        }
    }
}
