﻿namespace Verifiabled.Constructs
{
    public sealed class DefaultThatAsyncConstruct<TActual> : IThatAsyncConstruct<TActual>
    {
        public Task<TActual> Actual { get; }

        public DefaultThatAsyncConstruct(Task<TActual> actual)
        {
            Actual = actual;
        }
    }
}