namespace KataStarbuzzCoffee
{
    internal class Honey : Beverage
    {
        private Beverage beverage;
        private int price = 4;

        public Honey(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetTotalDescription()
        {
            return this.beverage.GetTotalDescription() + " + Honey (" + price + ")";
        }

        public override int GetTotalPrice()
        {
            return this.beverage.GetTotalPrice() + price;
        }
    }
}