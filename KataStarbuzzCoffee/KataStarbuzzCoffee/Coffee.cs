namespace KataStarbuzzCoffee
{
    internal class Coffee : Beverage
    {
        public Coffee(int price)
        {
            Price = price;
        }

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