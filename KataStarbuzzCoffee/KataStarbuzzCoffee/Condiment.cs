namespace KataStarbuzzCoffee
{
    internal abstract class Condiment : Beverage
    {
        protected Beverage beverage;

        public Condiment(Beverage beverage, int price)
        {
            this.beverage = beverage;
            Price = price;
        }

    }
}