namespace Verifiabled.Constructs
{
    internal sealed class DefaultActionConstruct : IThatActionConstruct
    {
        public Action Act { get; }

        public DefaultActionConstruct(Action act)
        {
            Act = act;
        }
    }
}
