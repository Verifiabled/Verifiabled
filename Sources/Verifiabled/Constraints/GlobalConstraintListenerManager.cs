namespace Verifiabled.Constraints
{
    internal static class GlobalConstraintListenerManager
    {
        public static IConstraintListener Listener { get; private set; } = Create();
        public static void Add(Constraint contraint) => Listener.Add(contraint);
        public static void Prepare() => Listener = Create();

        private static DefaultConstraintListener Create() => new();
    }
}
