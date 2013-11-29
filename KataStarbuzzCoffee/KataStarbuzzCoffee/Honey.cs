﻿namespace KataStarbuzzCoffee
{
    internal class Honey : Beverage
    {
        private Beverage beverage;

        public Honey(Beverage beverage)
        {
            this.beverage = beverage;
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