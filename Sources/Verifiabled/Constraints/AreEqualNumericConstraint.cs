using System.Numerics;

namespace Verifiabled.Constraints.NumericConstraints
{
    internal sealed class AreEqualNumericConstraint<T> : ConstraintAbstract<T> where T : INumber<T>
    {
        internal T Error { get; set; }

        public AreEqualNumericConstraint(T expected, T actual, T error) : base(expected, actual)
        {
            Error = error;
            UpdateFulfillment();
        }

        protected override void UpdateFulfillment()
        {
            var absMeasuredError = T.Abs(Expected > Actual ? Expected - Actual : Actual - Expected);
            IsFulfilled = absMeasuredError <= T.Abs(Error);
        }
    }
}
