using System;

namespace KataStarbuzzCoffee
{
    internal class Milk : Beverage
    {
        private Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetTotalDescription()
        {
            return beverage.GetTotalDescription() + " + Milk (3.50)";
        }

        public override string GetTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}