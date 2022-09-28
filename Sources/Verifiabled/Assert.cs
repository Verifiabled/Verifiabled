using System.Runtime.CompilerServices;
using Verifiabled.Constructs;

namespace Verifiabled
{
    public static class Assert
    {
        public static IThatConstruct<TActual> That<TActual>(TActual actual, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0)
            => new DefaultThatConstruct<TActual>(actual, new SourceOrigin(filePath, lineNumber));
    }
}