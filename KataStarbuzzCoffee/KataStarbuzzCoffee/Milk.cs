using System;

namespace KataStarbuzzCoffee
{
    internal class Milk : Beverage
    {
        private Beverage beverage;
        private int price = 3;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetTotalDescription()
        {
            return beverage.GetTotalDescription() + " + Milk (" + price + ")";
        }

        public override int GetTotalPrice()
        {
            return this.beverage.GetTotalPrice() + price;
        }
    }
}