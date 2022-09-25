namespace Verifiabled.Constructs
{
    public interface IThatArrayConstruct<TActual>
    {
        TActual[] Actual { get; }
    }
}