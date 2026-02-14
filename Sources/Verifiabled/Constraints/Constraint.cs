namespace Verifiabled.Constraints
{
    public readonly record struct Constraint(bool IsFulfilled, string? FailureMessage)
    {
        public readonly static Constraint Fulfilled = new(true, null);
        public static Constraint Create(bool isFulfilled, string? failureMessage)
            => isFulfilled ? Fulfilled : new Constraint(false, failureMessage);
    }
}
