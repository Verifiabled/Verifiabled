namespace Verifiabled
{
    public sealed class ExampleTestSet
    {
        [Case]
        public void ExampleTestCase()
        {
            var apple = new Apple();
            var basket = new Basket();
            var mover = new Mover();

            mover.MoveInto(apple, basket);

            Assert.That(basket.Items).Contains(apple);
        }
    }

    internal sealed class Mover
    {
        public void MoveInto(Apple apple, Basket basket)
        {

        }
    }

    internal sealed class Basket
    {
        internal IEnumerable<Apple> Items { get; } = Enumerable.Empty<Apple>();
    }

    internal sealed class Apple
    {
        
    }
}