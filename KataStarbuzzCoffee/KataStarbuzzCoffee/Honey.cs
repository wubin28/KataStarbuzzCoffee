namespace KataStarbuzzCoffee
{
    internal class Honey : Condiment
    {
        public Honey(Beverage beverage, int price) : base(beverage, price)
        {
        }

        public override string GetTotalDescription()
        {
            return this.beverage.GetTotalDescription() + " + Honey (" + Price + ")";
        }

        public override int GetTotalPrice()
        {
            return this.beverage.GetTotalPrice() + Price;
        }
    }
}