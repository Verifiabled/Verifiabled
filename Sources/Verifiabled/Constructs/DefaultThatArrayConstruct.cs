namespace Verifiabled.Constructs
{
    internal sealed class DefaultThatArrayConstruct<TActual> : IThatArrayConstruct<TActual>
    {
        public TActual[] Actual { get; }

        public DefaultThatArrayConstruct(TActual[] actual)
        {
            Actual = actual;
        }
    }
}