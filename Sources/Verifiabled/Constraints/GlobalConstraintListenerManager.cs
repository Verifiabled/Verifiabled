namespace Verifiabled.Constraints
{
    public static class GlobalConstraintListenerManager
    {
        public static IConstraintListener Listener { get; private set; } = Create();
        public static void Broadcast(IContraint contraint) => Listener.Broadcast(contraint);
        public static void Prepare() => Listener = Create();

        private static IConstraintListener Create() => new DefaultConstraintListener();
    }
}
