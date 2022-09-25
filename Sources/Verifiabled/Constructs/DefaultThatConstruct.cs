namespace Verifiabled.Constructs
{
    public sealed class DefaultThatConstruct<TActual> : IThatConstruct<TActual>
    {
        public TActual Actual { get; }

        public DefaultThatConstruct(TActual actual)
        {
            Actual = actual;
        }
    }
}
