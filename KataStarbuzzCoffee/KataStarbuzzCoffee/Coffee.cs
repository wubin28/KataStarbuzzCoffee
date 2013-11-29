namespace KataStarbuzzCoffee
{
    internal class Coffee : Beverage
    {
        public override string GetTotalDescription()
        {
            return "Coffee (" + price + ")";
        }

        public override int GetTotalPrice()
        {
            return price;
        }
    }
}