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
            return beverage.GetTotalDescription() + " + Milk (" + Price + ")";
        }

        public override int GetTotalPrice()
        {
            return this.beverage.GetTotalPrice() + Price;
        }
    }
}