namespace KataStarbuzzCoffee
{
    internal class Coffee : Beverage
    {
        private int price = 22;

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