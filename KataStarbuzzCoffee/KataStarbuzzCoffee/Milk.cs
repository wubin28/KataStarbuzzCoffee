using System;

namespace KataStarbuzzCoffee
{
    internal class Milk : Condiment
    {
        public Milk(Beverage beverage, int price) : base(beverage, price)
        {
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