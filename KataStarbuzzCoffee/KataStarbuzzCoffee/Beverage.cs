namespace KataStarbuzzCoffee
{
    abstract class Beverage
    {
        protected int Price = 0;
        public abstract string GetTotalDescription();
        public abstract int GetTotalPrice();
    }
}