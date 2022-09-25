namespace Verifiabled.Constructs
{
    public sealed class DefaultActionConstruct : IThatActionConstruct
    {
        public Action Act { get; }

        public DefaultActionConstruct(Action act)
        {
            Act = act;
        }
    }
}
