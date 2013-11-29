namespace KataStarbuzzCoffee
{
    internal class Coffee : Beverage
    {
        public override string GetTotalDescription()
        {
            return "Coffee(22.00)";
        }

        public override string GetTotalPrice()
        {
            return "Total=22.00";
        }
    }
}