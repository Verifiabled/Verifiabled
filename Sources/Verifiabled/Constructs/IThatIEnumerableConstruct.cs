namespace Verifiabled.Constructs
{
    public interface IThatIEnumerableConstruct<TActual>
    {
        public IEnumerable<TActual> Actual { get; }
    }
}
