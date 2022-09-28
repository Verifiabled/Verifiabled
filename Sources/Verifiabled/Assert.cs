using Verifiabled.Constructs;

namespace Verifiabled
{
    public static class Assert
    {
        public static IThatConstruct<TActual> That<TActual>(TActual actual) => new DefaultThatConstruct<TActual>(actual);
    }
}