namespace KataStarbuzzCoffee
{
    internal class Coffee : Beverage
    {
        public override string GetTotalDescription()
        {
            return "Coffee (" + Price + ")";
        }

        public override int GetTotalPrice()
        {
            return Price;
        }
    }
}