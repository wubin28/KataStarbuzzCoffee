namespace KataStarbuzzCoffee
{
    abstract class Beverage
    {
        protected int price = 0;
        public abstract string GetTotalDescription();
        public abstract int GetTotalPrice();
    }
}