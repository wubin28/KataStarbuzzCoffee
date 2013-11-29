namespace KataStarbuzzCoffee
{
    internal class Honey : Beverage
    {
        public Honey(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetTotalDescription()
        {
            throw new System.NotImplementedException();
        }

        public override int GetTotalPrice()
        {
            throw new System.NotImplementedException();
        }
    }
}