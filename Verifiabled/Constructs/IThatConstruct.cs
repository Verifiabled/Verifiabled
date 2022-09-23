namespace Verifiabled.Constructs
{
    public interface IThatConstruct<TActual>
    {
        TActual Actual { get; }
    }
}
