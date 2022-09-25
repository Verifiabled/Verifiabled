namespace Verifiabled.Constructs
{
    public sealed class DefaultThatIEnumerableConstruct<TActual> : IThatIEnumerableConstruct<TActual>
    {
        public IEnumerable<TActual> Actual { get; }

        public DefaultThatIEnumerableConstruct(IEnumerable<TActual> actual)
        {
            Actual = actual;
        }
    }
}
