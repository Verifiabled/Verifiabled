using Verifiabled.Constructs;

namespace Verifiabled
{
    public static class Assert
    {
        public static IThatConstruct<TActual> That<TActual>(TActual actual)
        {
            throw new NotImplementedException();
        }

        public static IThatAsyncConstruct<TActual> That<TActual>(Task<TActual> actual)
        {
            throw new NotImplementedException();
        }

        public static IThatActionConstruct That(Action act)
        {
            throw new NotImplementedException();
        }

        public static IThatIEnumerableConstruct<TActual> That<TActual>(IEnumerable<TActual> actual)
        {
            throw new NotImplementedException();
        }
    }
}