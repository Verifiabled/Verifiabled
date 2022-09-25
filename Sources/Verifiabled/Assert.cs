using Verifiabled.Constructs;

namespace Verifiabled
{
    public static class Assert
    {
        public static IThatConstruct<TActual> That<TActual>(TActual actual) => new DefaultThatConstruct<TActual>(actual);

        public static IThatAsyncConstruct<TActual> That<TActual>(Task<TActual> actual) => new DefaultThatAsyncConstruct<TActual>(actual);

        public static IThatActionConstruct That(Action act) => new DefaultActionConstruct(act);

        public static IThatIEnumerableConstruct<TActual> That<TActual>(IEnumerable<TActual> actual) => new DefaultThatIEnumerableConstruct<TActual>(actual);

        public static IThatArrayConstruct<TActual> That<TActual>(TActual[] actual) => new DefaultThatArrayConstruct<TActual>(actual);
    }
}