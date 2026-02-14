using System.Diagnostics;
using Verifiabled.Exceptions;

namespace Verifiabled
{
    public static class ThrowsExtensions
    {
        extension(Assert)
        {
            [StackTraceHidden]
            public static void Throws<TException>(Action act) where TException : Exception
            {
                try
                {
                    act();
                    throw new AssertException($"No exception thrown.\nExpected: {typeof(TException).Name}");
                }
                catch (Exception ex)
                {
                    if (ex is TException)
                        return;

                    throw new AssertException($"Unexpected exception thrown.\nExpected: {typeof(TException).Name}\nActual: {ex.GetType().Name}");
                }
            }
        }
    }
}
