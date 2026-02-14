using System.Diagnostics;
using Verifiabled.Constraints;

namespace Verifiabled
{
    public static class ThrowsExtensions
    {
        extension(Assert)
        {
            [StackTraceHidden]
            public static void Throws<TException>(Action act) where TException : Exception
                => GlobalConstraintListenerManager.Add(ThrowsConstraint.Create<TException>(act));
        }
    }
}
