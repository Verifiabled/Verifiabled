namespace Verifiabled.Constructs
{
    public interface IThatAsyncConstruct<TActual>
    {
        public Task<TActual> Actual { get; }
    }
}
