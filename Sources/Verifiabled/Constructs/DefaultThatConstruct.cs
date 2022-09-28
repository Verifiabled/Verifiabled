namespace Verifiabled.Constructs
{
    internal sealed class DefaultThatConstruct<TActual> : IThatConstruct<TActual>
    {
        public TActual Actual { get; }
        public SourceOrigin SourceOrigin { get; }

        public DefaultThatConstruct(TActual actual, SourceOrigin sourceOrigin)
        {
            Actual = actual;
            SourceOrigin = sourceOrigin;
        }
    }
}
