namespace Verifiabled.Constraints
{
    public static class GlobalConstraintListenerManager
    {
        private static List<IConstraintListener> Listeners { get; } = new();

        public static void Add(IConstraintListener constraintListener) => Listeners.Add(constraintListener);
        public static IEnumerable<IConstraintListener> GetAllConstraintListeners() => Listeners;
        public static void Broadcast(IContraint contraint) => Listeners.ForEach(listener => listener.Broadcast(contraint));
        public static void Clear() => Listeners.Clear();
    }
}
