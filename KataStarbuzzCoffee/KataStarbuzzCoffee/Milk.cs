using System;

namespace KataStarbuzzCoffee
{
    internal class Milk : Beverage
    {
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetTotalDescription()
        {
            throw new NotImplementedException();
        }

        public override string GetTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}