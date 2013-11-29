namespace KataStarbuzzCoffee
{
    internal class Coffee : Beverage
    {
        public override string GetTotalDescription()
        {
            return "Coffee (22)";
        }

        public override int GetTotalPrice()
        {
            return 22;
        }
    }
}